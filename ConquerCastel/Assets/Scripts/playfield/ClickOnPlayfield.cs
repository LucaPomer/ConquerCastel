using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ClickOnPlayfield : MonoBehaviour
{
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
    }
}
