﻿using UniRx;
using UnityEngine;

namespace ActiveObject
{
    public class SoliderView : ActiveObjectView
    {
        [SerializeField] private Animator anim;
        [SerializeField] private SoliderModell soliderM;

        private GameObject targetToFollow;
        
        public Animation onHitAnimation;
        
        // Start is called before the first frame update
        void Start()
        {
            soliderM.target.Subscribe(newTargetValue => 
                { targetToFollow = newTargetValue ? newTargetValue : null; });
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

        public void PlayHitAnimation()
        {
            onHitAnimation.Play();
        }

        private void FaceMovementDirection()
        {
            if (targetToFollow)
            {
                Vector3 direction = (targetToFollow.transform.position - transform.position).normalized;
                Quaternion look = Quaternion.LookRotation(direction);
                transform.rotation = look;
            }
            else
            {
            transform.LookAt(new Vector3(0,1,0));
            }

        }
    }
}