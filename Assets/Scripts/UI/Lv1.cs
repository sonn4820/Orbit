using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lv1 : MonoBehaviour
{
    public GameObject panel;
    public GameObject player;

    // Start is called before the first frame update
    public void Start()
    {
        panel.gameObject.SetActive(false);
    }
    public void Update()
    {
        if ( player == null)
        {
            panel.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    public void Restart()
    {
        SceneManager.LoadScene("1");
    }
}
