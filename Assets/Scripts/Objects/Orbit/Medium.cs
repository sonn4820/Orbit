using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medium : Orbit
{
    
    protected virtual void Start()
    {
        base.Start();
        speed = 325f;
        gForce = 1.5f;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        base.Update();
    }
}
