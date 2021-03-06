﻿using System.Collections;
using System.Collections.Generic;
using UI;
using UnityEngine;

public class PassiveObjectModell : MonoBehaviour
{

    [SerializeField] HealthBar healthBarUi;
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

    //true for dead
    public virtual void ReductHealth(float hitPoints)
    {
        health -= hitPoints;
        healthBarUi.SetHealth(health);
        
        if (health <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    public bool IsAlive()
    {
        return health > 0;
    }
}
