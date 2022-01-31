using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public Transform Player;
    private Vector3 dir;
    [Range(0, 6)]
    public float gForce = 3f;
    [Range(0, 2)]
    public float speed;
    // Start is called before the first frame update
    protected void Start()
    {
     //   Player = GetComponent<Player>().transform;
    }

    // Update is called once per frame
    protected void Update()
    {    
        transform.Rotate(0, 0, speed);
    }
}
