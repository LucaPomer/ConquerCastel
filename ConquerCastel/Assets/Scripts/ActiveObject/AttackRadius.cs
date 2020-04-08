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
        activeV.Attack(other.gameObject);
    }
    
    private void OnTriggerExit(Collider other)
    {
        
    }
    
    
}
