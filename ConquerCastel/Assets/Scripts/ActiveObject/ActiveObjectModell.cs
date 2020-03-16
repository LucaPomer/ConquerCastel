using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ActiveObjectModell : MonoBehaviour
{
    public float health;

    public float attackDamage;

    public float attackEveryXSecond;

    public float attackRangeRadius;

    public int lvl;

    public GameObject target;

    public List<GameObject> targetsInRange;
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

    public void ResetTargetToNull()
    {
        target = null;
    }

    public GameObject GetTarget()
    {
        return target;
    }
    
    public void ReductHealth(float hitPoints)
    {
        health -= hitPoints;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void AddTargetToList(GameObject targetToAdd)
    {
        targetsInRange.Add(targetToAdd);
    }

    public GameObject GetNextTarget()
    {
        //Todo null target handeling - if the target dies from other reasons
        GameObject nextTarget = targetsInRange.First();
        targetsInRange.Remove(nextTarget);
        return nextTarget;
    }
    
    public void RemoveTargetFromList(GameObject targetToRemove)
    {
        targetsInRange.Remove(targetToRemove);
    }
   
    
    
}
