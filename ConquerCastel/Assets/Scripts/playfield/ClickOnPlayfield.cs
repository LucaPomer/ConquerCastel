﻿using System;
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
      
        GameObject toSpawn = inventory.GetPrefabToSpawn();
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit)&& toSpawn)
        {
            Vector3 clickedPosition = new Vector3(hit.point.x,1,hit.point.z);
            Debug.Log("clicked on playfield" + clickedPosition);
            
            Instantiate( toSpawn
                , clickedPosition
                ,Quaternion.identity);
        }
      /**  Instantiate( toSpawn
            , Camera.main.ScreenToWorldPoint(Input.mousePosition)
            ,Quaternion.identity);**/
        
    }
}
