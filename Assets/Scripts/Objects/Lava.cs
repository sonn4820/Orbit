using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    float speed = 0.008f;
    
    // Start is called before the first frame update
    void Start()
    {
        //speed += Time.deltaTime * 0.3f;
    }

    // Update is called once per frame
    void Update()
    {
        // declare a Vector 2 variable which adds speed to the current position
        Vector2 newPos = new Vector2(transform.position.x , transform.position.y + speed);

        //put the box in the new position
        transform.position = newPos;
    }
}
