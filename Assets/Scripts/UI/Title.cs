using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    public GameObject panel;
    public GameObject panel2;

    public void Start()
    {
        panel.gameObject.SetActive(false);
        panel2.gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    public void Play()
    {
        SceneManager.LoadScene("1");
    }
    public void Option1()
    {
        panel.gameObject.SetActive(true);
    }
    public void Option2()
    {
        panel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void Credit1()
    {
        panel2.gameObject.SetActive(true);
    }
    public void Credit2()
    {
        panel2.gameObject.SetActive(false);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
