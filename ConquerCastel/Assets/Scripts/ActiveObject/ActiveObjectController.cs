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
       SearchForTarget();
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

    public virtual void Attack(GameObject toAttack, Action onFinished)
    {
        if (activeObjectModell.GetTarget() == toAttack)
        {
            StartCoroutine(GiveDamage(toAttack, onFinished).GetEnumerator());
        }
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
        SearchForTarget();

    }

    private void SearchForTarget()
    {
        Collider[] inAttackRangeColliders = Physics.OverlapSphere(gameObject.transform.position, activeObjectModell.attackRangeRadius);
        int i = 0;
        while (i < inAttackRangeColliders.Length)
        {
            GameObject inRange = inAttackRangeColliders[i].gameObject;
            if (inRange.CompareTag("enemy"))
            {
                activeObjectModell.SetTarget(inRange);
                Attack(inRange,()=>{});
                break;
            }
            i++;
        }
    }

}
