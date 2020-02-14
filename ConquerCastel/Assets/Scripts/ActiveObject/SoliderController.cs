using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoliderController : ActiveObjectController
{
    public SoliderModell soliderM;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (soliderM.GetMovingStatus()==true)
        {
            Move();
        }
   
    }

    private void Move()
    {
        if (soliderM.GetTarget())
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

     public override void Attack(GameObject toAttack) 
    {
       
      
        if ( toAttack.CompareTag("enemy"))
        {
            
            base.Attack(toAttack);
            
            soliderM.SetMovingStatus(false);
            
            if (soliderM.GetTarget() != null)
            {
                Debug.Log("SOLIDER CONTROLLER : attacking enemy");
            }

            else
            {
                soliderM.SetTarget(toAttack);
                Debug.Log("SOLIDER CONTROLLER : attacking and adding enemy");
            }
            
        }
    }


}
