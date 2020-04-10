using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoliderView : ActiveObjectView
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        anim.SetBool("moving",true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetMovingAnimation(bool moving)
    {
        if (moving)
        {
            anim.SetBool("moving",true);
        }
        else
        {
            anim.SetBool("moving",false);
        }
        
    }

    public void SetAttackingAnimation(bool attacking)
    {
        if (attacking)
        {
            anim.SetBool("attacking",true);
        }
        else
        {
            anim.SetBool("attacking",false);
        }
    }
    
    
    
   
}
