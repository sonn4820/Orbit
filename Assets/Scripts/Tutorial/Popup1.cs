using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup1 : MonoBehaviour
{
    public GameObject text;
    public GameObject title;
    private void Start()
    {
        text.SetActive(false);
        title.SetActive(false);
    }
    // Start is called before the first frame update
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            text.SetActive(true);
            title.SetActive(true);
        }
    }
}
