using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassiveObjectController : MonoBehaviour
{
    [SerializeField] private PassiveObjectModell passiveObjectModell;

    [SerializeField] private PassiveObjectView passiveObjectView;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hit(float hitPoints)
    {
        //Debug.Log("PASIVE OBJECT CONTROLLER : hit");
        passiveObjectModell.ReductHealth(hitPoints);
        passiveObjectView.PlayHitAnimation();
    }

    public bool IsAlive()
    {
        return passiveObjectModell.IsAlive();
    }
}
