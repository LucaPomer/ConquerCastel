using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRadius : MonoBehaviour
{
    public ActiveObjectController objectOfTriggerController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered vision trigger");
        //Todo remove redundent step
            objectOfTriggerController.SetTarget(other.gameObject);
            
            objectOfTriggerController.AddTargetToList(other.gameObject);           
            
    }

    private void OnTriggerExit(Collider other)
    {
        objectOfTriggerController.RemoveTargetFromList(other.gameObject);
    }
}
