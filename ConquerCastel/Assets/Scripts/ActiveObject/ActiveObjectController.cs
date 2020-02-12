using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveObjectController : MonoBehaviour
{
    private ActiveObjectModell activeObjectModell;
    // Start is called before the first frame update
    private void Awake()
    {
        activeObjectModell = GetComponent<ActiveObjectModell>();
    }

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetTarget(GameObject target)
    {
        activeObjectModell.SetTarget(target);
    }
}
