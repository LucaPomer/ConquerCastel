using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using ActiveObject;
using UnityEngine;

public class SoliderController : ActiveObjectController
{
    public SoliderModell soliderM;

    public SoliderView soliderV;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!soliderM.GetTarget())
        {
            base.SearchForTarget();
        }
        
        if (soliderM.GetMovingStatus()==true)
        {
            Move();
        }
   
    }

    private void Move()
    {
        if (soliderM.GetTarget()!=null)
        {
            transform.position = Vector3.MoveTowards(transform.position,
                soliderM.GetTarget().transform.position, Time.deltaTime * soliderM.movementSpeed);
           // transform.Translate(activeObjectModell.GetTarget().transform.position * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position,
                new Vector3(0,0,0), Time.deltaTime * soliderM.movementSpeed);
        }
    }

     public override void Attack(GameObject toAttack, Action onFinished) 
    {
       
      
        if ( toAttack.CompareTag("enemy"))
        {
            
            soliderM.SetMovingStatus(false);
            soliderV.SetMovingAnimation(false);
            soliderV.SetAttackingAnimation(true);
            
            base.Attack(toAttack,(() => AfterTargetDied()));
            
            
            if (soliderM.GetTarget() == null)
            {
                soliderM.SetTarget(toAttack);
            }

            
        }
        
    }

     Action AfterTargetDied()
     {
         soliderM.SetMovingStatus(true);
         soliderV.SetMovingAnimation(true);
         soliderV.SetAttackingAnimation(false);
         return null;
     }


}
