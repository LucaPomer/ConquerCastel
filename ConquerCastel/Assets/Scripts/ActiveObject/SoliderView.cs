using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoliderView : ActiveObjectView
{
    [SerializeField] private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim.SetBool("moving", true);
    }

    // Update is called once per frame
    void Update()
    {
        FaceMovementDirection();
    }

    public void SetMovingAnimation(bool moving)
    {
        anim.SetBool("moving", moving);
    }

    public void SetAttackingAnimation(bool attacking)
    {
        anim.SetBool("attacking", attacking);
    }

    private void FaceMovementDirection()
    {
        //todo make work

        transform.position = gameObject.transform.position;
        transform.LookAt(transform.position + gameObject.GetComponent<Rigidbody>().velocity);
    }
}