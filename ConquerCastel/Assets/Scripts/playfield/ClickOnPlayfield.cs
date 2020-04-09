using System;
using System.Collections;
using System.Collections.Generic;
using UI;
using UnityEditor;
using UnityEngine;

public class ClickOnPlayfield : MonoBehaviour

{

    public InventoryParent inventory;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        Debug.Log("clicked on playfield" + Input.mousePosition);
        GameObject toSpawn = inventory.GetPrefabToSpawn();
      /**  Instantiate( toSpawn
            , Camera.main.ScreenToWorldPoint(Input.mousePosition)
            ,Quaternion.identity);**/
        
    }
}
