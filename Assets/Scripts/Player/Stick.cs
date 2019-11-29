using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{
    private Transform circleAttachedTo;
    private bool onCircle;
    private Vector3 moveDirection = Vector3.down; //Start by moving down.


    private void Update()
    {
        //If not on the circle, keep moving in moveDirection.
        if (onCircle)
        { 
            moveDirection = (transform.position - circleAttachedTo.position);
            Debug.DrawLine(transform.position, transform.position + moveDirection);
            //Jumped, so detach from circle.
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Jumped!");
                onCircle = false;
                transform.SetParent(null);
            }
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "orbit")
        {
            Debug.Log("Hit Circle!");
            onCircle = true;
            circleAttachedTo = collision.transform;
            transform.SetParent(circleAttachedTo);
        }
      
    }
}