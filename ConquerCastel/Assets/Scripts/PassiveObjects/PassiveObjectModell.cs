using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassiveObjectModell : MonoBehaviour
{

    public Vector3 positionOnPlayfield;
    public float health;

    private void Awake()
    {
        //forNow..
        positionOnPlayfield = gameObject.transform.position;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReductHealth(float hitPoints)
    {
        health -= hitPoints;
    }
}
