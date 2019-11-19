using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    public GameObject panel;

    public void Start()
    {
        panel.gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    public void Play()
    {
        SceneManager.LoadScene("Menu");
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
    public void Credit()
    {
        SceneManager.LoadScene("Credit");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
