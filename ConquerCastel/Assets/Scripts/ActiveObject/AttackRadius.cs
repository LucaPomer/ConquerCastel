using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackRadius : MonoBehaviour
{
    public ActiveObjectView activeV;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ATTACK RADIUS : entered attack trigger");
        activeV.Attack(other.gameObject);
    }
    
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("ATTACK RADIUS : exit trigger");
    }
    
    
}
