
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;   // public var that refers to the game object we want to follow player/ball
    private Vector3 offset;   // private var that determines the camera distance from the player/ball

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        position.y = (player.transform.position + offset).y;
        transform.position = position;
    }
}