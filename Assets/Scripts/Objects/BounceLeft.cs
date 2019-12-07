using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceLeft : MonoBehaviour
{
    public GameObject player;
    public void Update()
    {

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            player.GetComponent<Rigidbody2D>().velocity = new Vector2(5, 0);
        }
    }
}
