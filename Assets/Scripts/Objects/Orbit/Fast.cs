using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fast : Orbit
{
   
    protected virtual void Start()
    {
        base.Start();
        speed = 1.5f;
        gForce = 2f;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        base.Update();
    }
}
