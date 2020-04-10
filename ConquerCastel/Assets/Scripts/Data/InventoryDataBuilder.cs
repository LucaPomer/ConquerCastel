using System.Collections.Generic;
using enums;
using UnityEngine;

namespace Data
{
    public class InventoryDataBuilder 
    {
        public InventoryData CreateInventoryData()
        {
           InventoryData beginnerData = new InventoryData();

           List<InventoryData.InventoryItemDataT> inventoryItemsData = beginnerData.inventoryItemsData;
           inventoryItemsData.Add(new InventoryData.InventoryItemDataT
           {
               amountAvailable = 5,
               typeEnum = InventoryItemsEnum.SimpleWarrior
           });
           
           inventoryItemsData.Add(new InventoryData.InventoryItemDataT
           {
               amountAvailable = 5,
               typeEnum = InventoryItemsEnum.BowWarrior
           });

           return beginnerData;
        }
    }
}
