using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UniRx;
using UnityEngine;

public class ActiveObjectModell : MonoBehaviour
{
    public float health;

    public float attackDamage;

    public float attackEveryXSecond;

    public float attackRangeRadius;

    public int lvl;

    public ReactiveProperty<GameObject> target = new ReactiveProperty<GameObject>();

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
        if (target.Value==null && targetToSet.CompareTag("enemy"))
        {
            this.target.Value = targetToSet;
         //   Debug.Log("set Target");
        }
        
    }

    public void ResetTargetToNull()
    {
        target.Value = null;
    }

    public GameObject GetTarget()
    {
        return target.Value;
    }
    
    public void ReductHealth(float hitPoints)
    {
        health -= hitPoints;
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
