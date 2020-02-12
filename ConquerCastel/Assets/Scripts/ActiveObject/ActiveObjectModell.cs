using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveObjectModell : MonoBehaviour
{
    public float health;

    public float attackDamage;

    public float attackSpeed;

    public float attackRangeRadius;

    public int lvl;

    private GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetTarget(GameObject targetToSet)
    {
        if (target==null && targetToSet.CompareTag("enemy"))
        {
            this.target = targetToSet;
            Debug.Log("set Target");
        }
    }

    public GameObject GetTarget()
    {
        return target;
    }
    
    
}
