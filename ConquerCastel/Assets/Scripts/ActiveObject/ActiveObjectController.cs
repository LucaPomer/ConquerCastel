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
    
    public virtual void Attack(GameObject toAttack)
    {
        StartCoroutine(GiveDamage(toAttack));
    }
    
    
    //is only called after establishing this object should be hit
    IEnumerator GiveDamage(GameObject toAttack)
    {
        bool hasTarget = true;
        while (hasTarget)
        {
            ActiveObjectController activeController = toAttack.GetComponent<ActiveObjectController>();
            PassiveObjectController passiveController = toAttack.GetComponent<PassiveObjectController>();
            if (activeController)
            {
                activeController.Hit(activeObjectModell.attackDamage);
            }
            else if(passiveController)
            {
               
                passiveController.Hit(activeObjectModell.attackDamage);
            }

           yield return new WaitForSeconds(activeObjectModell.attackEveryXSecond);
           if (activeObjectModell.GetTarget() == null)
           {
               hasTarget = false;
            
           }

        }
  
      
    }

}
