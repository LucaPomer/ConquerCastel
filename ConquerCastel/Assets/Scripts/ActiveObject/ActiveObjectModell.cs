using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using enums;
using UI;
using UniRx;
using UnityEngine;

public class ActiveObjectModell : MonoBehaviour
{
    [SerializeField] protected TagsEnum toAttackTagName;
    public float health;

    public HealthBar healthBarUi;

    public float attackDamage;

    public float attackEveryXSecond;

    public float attackRangeRadius;

    public int lvl;

    public ReactiveProperty<GameObject> target = new ReactiveProperty<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        healthBarUi.SetMaxHealth(health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetTarget(GameObject targetToSet)
    {
        if (target.Value==null && targetToSet.CompareTag(toAttackTagName.ToString()))
        {
            this.target.Value = targetToSet;
           Debug.Log("set Target" + targetToSet);
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
        
        //todo make better in mvc
        healthBarUi.SetHealth(health);
        
        if (health <= 0)
        {
            gameObject.SetActive(false);
        }
    }
    
    public bool IsAlive()
    {
        return health > 0;
    }

    public string GetToAttackNameTag()
    {
        return toAttackTagName.ToString();
    }


   
    
    
}
