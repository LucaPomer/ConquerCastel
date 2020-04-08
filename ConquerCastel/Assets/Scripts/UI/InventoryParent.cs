using System.Collections;
using System.Collections.Generic;
using scriptableObjects;
using UI;
using UnityEngine;

public class InventoryParent : MonoBehaviour
{
    private int inventoryItemsAmount = 5;
    public List<InventoryButton> inventoryItems= new List<InventoryButton>();

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
            inventoryItems.Add(inventoryItem.GetComponent<InventoryButton>());
        }
    }
    
}
