using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRadius : MonoBehaviour
{
    public ActiveObjectController objectOfTrigger;

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
        Debug.Log("entered trigger");
            objectOfTrigger.SetTarget(other.gameObject);
    }
}
