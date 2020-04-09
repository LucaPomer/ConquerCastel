using System.Collections.Generic;
using scriptableObjects;
using UnityEngine;

namespace UI
{
    public class InventoryParent : MonoBehaviour
    {
        private int inventoryItemsAmount = 5;
        public List<InventorySlot> inventoryItems= new List<InventorySlot>();

        public PrefabToItemImage scriptablePrefabToItemImage;
    
        public GameObject inventoryButtonPrefab;
        // Start is called before the first frame update
        void Start()
        {
            CreateInventoryItems();
        

        }

        // Update is called once per frame
        void Update()
        {
        
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

        private InventorySlot SetInventorySlotData(InventorySlot toSet, int index)
        {
            toSet.SetItemImage(scriptablePrefabToItemImage.inventoryItemsData[index].imageInInventory);
            toSet.SetPrefabToSpawn(scriptablePrefabToItemImage.inventoryItemsData[index].connectedPrefab);
            return toSet;
        }
    
    }
}
