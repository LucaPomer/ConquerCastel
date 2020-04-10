using System;
using System.Collections.Generic;
using enums;
using scriptableObjects;
using UnityEngine;

namespace Data
{

    [Serializable]
    public class InventoryData 
    {

        public List<InventoryItemDataT> inventoryItemsData = new List<InventoryItemDataT>();
        
        
        [Serializable]
        public class InventoryItemDataT
        {
            public int amountAvailable;
            public InventoryItemsEnum typeEnum;

        }
    }
}
