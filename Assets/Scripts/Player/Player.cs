using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool grounded1 = false;
    public bool grounded2 = false;
    public GameObject groundCheck1 = null;
    public GameObject groundCheck2 = null;
    float runSpeed = 4;
    float jumpForce = 400;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(transform.position, groundCheck1.transform.position);
        Debug.DrawLine(transform.position, groundCheck2.transform.position);

        if (Physics2D.Linecast(transform.position, groundCheck1.transform.position))
        {
            grounded1 = true;

        }
        else
        {
            grounded1 = false;
        }

        if (Physics2D.Linecast(transform.position, groundCheck2.transform.position))
        {
            grounded2 = true;

        }
        else
        {
            grounded2 = false;
        }

        float currentYVel = GetComponent<Rigidbody2D>().velocity.y;

        if (Input.GetKeyDown(KeyCode.Space) && grounded2)
        {

            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
        }
        else if (Input.GetKeyDown(KeyCode.Space) && grounded1)
        {

            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -jumpForce));
        }
    }
}
