using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlashyWin : MonoBehaviour
{
    public GameObject flashing_Label;

    public float interval;

    void Start()
    {
        InvokeRepeating("FlashLabel", 0.6f, interval);
    }

    void FlashLabel()
    {
        if (flashing_Label.activeSelf)
            flashing_Label.SetActive(false);
        else
            flashing_Label.SetActive(true);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Title");
    }
}
