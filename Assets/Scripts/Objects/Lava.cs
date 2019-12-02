using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // declare a Vector 2 variable which adds speed to the current position
        Vector2 newPos = new Vector2(transform.position.x , transform.position.y + speed * Time.deltaTime);

        //put the box in the new position
        transform.position = newPos;
    }
}
