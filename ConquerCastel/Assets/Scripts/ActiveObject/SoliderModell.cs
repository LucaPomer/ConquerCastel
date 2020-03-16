using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoliderModell : ActiveObjectModell 

{
    public float movementSpeed = 0.2f;

    public bool moving =true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool GetMovingStatus()
    {
        return moving;
    }

    public void SetMovingStatus(bool status)
    {
        moving = status;
    }
}
