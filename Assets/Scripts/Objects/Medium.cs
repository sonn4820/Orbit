﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medium : MonoBehaviour
{
    public Transform Player;
    public float gForce = 6f;
    private Vector3 dir;
    public float SpinSpeed;

    // Start is called before the first frame update
    //void Start()
    //{
    //    dir = Vector3.zero;
    //}
    //public void FixedUpdate()
    //{
    //    dir = (transform.position - Player.position).normalized;
    //    Player.GetComponent<Rigidbody2D>().AddForce(dir * gForce);
    //}

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, SpinSpeed);
    }
}
