using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform circleAttachedTo;
    private bool onCircle;
    private Vector3 moveDirection = Vector3.down; //Start by moving down.
    Rigidbody2D RB;
    float jumpForce = 900f;
    

    private void Update()
    {

        //If not on the circle, keep moving in moveDirection.
        if (!onCircle)
        {
            transform.position += moveDirection * 2 * Time.deltaTime;
        }
        //If on the circle, update our moveDirection vector and wait for SPACE to jump.
        else
        {
            moveDirection = (transform.position - circleAttachedTo.position);
            Debug.DrawLine(transform.position, transform.position + moveDirection);
            //Jumped, so detach from circle.
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
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

        if (collision.gameObject.tag == "lava")
        {
            Destroy(this.gameObject);
        }
    }
}