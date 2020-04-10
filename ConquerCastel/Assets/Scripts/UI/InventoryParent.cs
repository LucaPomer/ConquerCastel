using System.Collections.Generic;
using Data;
using enums;
using scriptableObjects;
using UniRx;
using UnityEngine;

namespace UI
{
    public class InventoryParent : MonoBehaviour
    {
        private int inventoryItemsAmount = 5;
        public List<InventorySlot> inventoryItems= new List<InventorySlot>();

        public PrefabToItemData scriptablePrefabToItemData;
    
        public GameObject inventoryButtonPrefab;
        
        private readonly ReactiveProperty<InventoryItemsEnum> selectedItem = new ReactiveProperty<InventoryItemsEnum>(InventoryItemsEnum.None);

        public ReactiveProperty<InventoryItemsEnum> SelectedItem => selectedItem;
        
        
        private InventoryDataHandler dataHandler = new InventoryDataHandler();

        private InventoryData playerInventoryData;

        // Start is called before the first frame update
        void Start()
        {
            playerInventoryData = dataHandler.LoadInventoryData();
            CreateInventoryItems();
            

        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void ChangeSelectedItem(InventoryItemsEnum newSelected)
        {
            selectedItem.Value = newSelected;
        }

        private void CreateInventoryItems()
        {
            foreach (var item in playerInventoryData.inventoryItemsData)
            {
                GameObject inventoryItemButton = Instantiate(inventoryButtonPrefab,gameObject.transform);
                InventorySlot currentSlot = inventoryItemButton.GetComponent<InventorySlot>();
                SetInventorySlotData(currentSlot, item);
                inventoryItems.Add(inventoryItemButton.GetComponent<InventorySlot>());
            
            }
        }

        private void SetInventorySlotData(InventorySlot toSet, InventoryData.InventoryItemDataT data)
        {
            PrefabToItemData.InventoryItemT itemInfo =
                scriptablePrefabToItemData.inventoryItems.Find(x => x.typeEnum == data.typeEnum);
            toSet.SetItemImage(itemInfo.imageInInventory);
            toSet.SetPrefabToSpawn(itemInfo.connectedPrefab);
            toSet.SetItemType(data.typeEnum);
            toSet.amountAvailible = data.amountAvailable;
            toSet.SetInventoryParent(this);
        }

        public GameObject GetPrefabToSpawn()
        {
            foreach (var item in inventoryItems)
            {
                if (item.GetItemTypeEnum() == selectedItem.Value)
                {
                    
                    return item.prefabToBeSpawned;
                }
            }

            return null;
        }
    
    }
}
