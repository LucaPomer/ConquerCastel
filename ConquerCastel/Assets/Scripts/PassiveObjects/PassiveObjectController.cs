using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassiveObjectController : MonoBehaviour
{
    private PassiveObjectModell passiveObjectModell;
    // Start is called before the first frame update
    void Start()
    {
        passiveObjectModell = GetComponent<PassiveObjectModell>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hit(float hitPoints)
    {
        Debug.Log("PASIVE OBJECT CONTROLLER : hit");
        passiveObjectModell.ReductHealth(hitPoints);
    }

    public bool IsAlive()
    {
        return passiveObjectModell.IsAlive();
    }
}
