using System;
using System.Collections.Generic;
using enums;
using UnityEngine;

namespace scriptableObjects
{
    [CreateAssetMenu(menuName = "PrefabToItemImage")]
    public class PrefabToItemImage : ScriptableObject
    {
        public List<InventoryItemT> inventoryItemsData = new List<InventoryItemT>();

        [Serializable]
        public class InventoryItemT
        {
            public GameObject connectedPrefab;
            public Sprite imageInInventory;
            public InventoryItemsEnum typeEnum;

        }
    }
}