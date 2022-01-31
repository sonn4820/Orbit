using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medium : Orbit
{
    
    protected virtual void Start()
    {
        base.Start();
        speed = 1.25f;
        gForce = 3f;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        base.Update();
    }
}
