using System.Collections.Generic;
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

        public PrefabToItemImage scriptablePrefabToItemImage;
    
        public GameObject inventoryButtonPrefab;
        
        private readonly ReactiveProperty<InventoryItemsEnum> selectedItem = new ReactiveProperty<InventoryItemsEnum>(InventoryItemsEnum.None);

        public ReactiveProperty<InventoryItemsEnum> SelectedItem => selectedItem;

        // Start is called before the first frame update
        void Start()
        {
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
            for (int i = 0; i < inventoryItemsAmount; i++)
            {
                GameObject inventoryItem = Instantiate(inventoryButtonPrefab,gameObject.transform);
                InventorySlot currentSlot = inventoryItem.GetComponent<InventorySlot>();
                SetInventorySlotData(currentSlot, i);
                inventoryItems.Add(inventoryItem.GetComponent<InventorySlot>());
            
            }
        }

        private void SetInventorySlotData(InventorySlot toSet, int index)
        {
            toSet.SetItemImage(scriptablePrefabToItemImage.inventoryItemsData[index].imageInInventory);
            toSet.SetPrefabToSpawn(scriptablePrefabToItemImage.inventoryItemsData[index].connectedPrefab);
            toSet.SetItemType(scriptablePrefabToItemImage.inventoryItemsData[index].typeEnum);
            toSet.SetInventoryParent(this);
        }

        public GameObject GetPrefabToSpawn()
        {
            foreach (var item in scriptablePrefabToItemImage.inventoryItemsData)
            {
                if (item.typeEnum == selectedItem.Value)
                {
                    Debug.Log("prefab returned" +item.connectedPrefab );
                    return item.connectedPrefab;
                }
            }

            return null;
        }
    
    }
}
