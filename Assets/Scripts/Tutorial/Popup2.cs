using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup2 : MonoBehaviour
{
    public GameObject text;
    private void Start()
    {
        text.SetActive(false);
    }
    // Start is called before the first frame update
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            text.SetActive(true);
        }
    }
}
