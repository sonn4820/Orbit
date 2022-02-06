using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Low : Orbit
{
   
    protected virtual void Start()
    {
        base.Start();
        speed = 175f;
        gForce = 1f;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        base.Update();
    }
}
