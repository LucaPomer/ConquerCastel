using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveObjectController : MonoBehaviour
{
    private ActiveObjectModell activeObjectModell;
    // Start is called before the first frame update
    private void Awake()
    {
        activeObjectModell = GetComponent<ActiveObjectModell>();
    }

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Hit(float hitPoints)
    {
        activeObjectModell.ReductHealth(hitPoints);
    }

    public void SetTarget(GameObject target)
    {
        activeObjectModell.SetTarget(target);
    }
    
    public virtual void Attack(GameObject toAttack,Action onFinished)
    {
        StartCoroutine(GiveDamage(toAttack, onFinished).GetEnumerator());
       
    }
    
    
    //is only called after establishing this object should be hit
    IEnumerable<WaitForSeconds> GiveDamage(GameObject toAttack, Action onFinished)
    {
        bool hasTarget = true;
        ActiveObjectController activeController = toAttack.GetComponent<ActiveObjectController>();
        PassiveObjectController passiveController = toAttack.GetComponent<PassiveObjectController>();
        while (hasTarget)
        {
          
            if (activeController)
            {
                activeController.Hit(activeObjectModell.attackDamage);
            }
            else if(passiveController)
            {
               
                passiveController.Hit(activeObjectModell.attackDamage);
            }

            if (activeObjectModell.GetTarget() == null)
            {
                hasTarget = false;
            
            }
           yield return new WaitForSeconds(activeObjectModell.attackEveryXSecond);
         

        }

       // activeObjectModell.ResetTargetToNull();
      //  Debug.Log("ACTIVE OBJECT MODEL: reset target to null");
        onFinished();

    }

    public void AddTargetToList(GameObject targetToAdd)
    {
        if (targetToAdd.CompareTag("enemy"))
        {
            activeObjectModell.AddTargetToList(targetToAdd);    
        }
        
    }

    public void RemoveTargetFromList(GameObject targetToRemove)
    {
        if (targetToRemove.CompareTag("enemy"))
        {
            activeObjectModell.RemoveTargetFromList(targetToRemove);         
        }
   
    }

    public GameObject GetNextTarget()
    {
       return activeObjectModell.GetNextTarget();
    }

}
