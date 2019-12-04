using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fast : MonoBehaviour
{
    public Transform Player;
    private float gForce = 4.5f;
    private Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        dir = Vector3.zero;
    }
    void FixedUpdate()
    {
        dir = (transform.position - Player.position).normalized;
        Player.GetComponent<Rigidbody2D>().AddForce(dir * gForce);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 4.5f);
    }
}
