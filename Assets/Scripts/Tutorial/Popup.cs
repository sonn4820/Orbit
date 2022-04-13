using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour
{
    public GameObject text;
    public GameObject layer1;
    public GameObject layer2;
    public GameObject title1;
    public GameObject title2;
    public GameObject layerexplain;
    private void Start()
    {
        text.SetActive(false);
        layer1.SetActive(false);
        layer2.SetActive(false);
        title1.SetActive(false);
        title2.SetActive(false);
        layerexplain.SetActive(false);

    }
    // Start is called before the first frame update
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            text.SetActive(true);   
            layer1.SetActive(true);
            layer2.SetActive(true);
            title1.SetActive(true);
            title2.SetActive(true);
            layerexplain.SetActive(true);
        }
    }
}
