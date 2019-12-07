using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHorizontal : MonoBehaviour
{
    //Code found from Unity Thread
    public float min = 1f;
    public float max = 2f;

    // Start is called before the first frame update
    void Start()
    {

        min = transform.position.x;
        max = transform.position.x + 3;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * 3, max - min) + min, transform.position.y, transform.position.z);
    }
}
