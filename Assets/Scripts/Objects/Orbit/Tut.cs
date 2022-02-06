using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tut : Orbit
{
   
    protected virtual void Start()
    {
        base.Start();
        speed = 50f;
        gForce = 5f;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        
    }
}
