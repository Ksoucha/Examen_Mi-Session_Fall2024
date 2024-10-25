using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    Camera playerCamera;
    public Rigidbody2D player;
   
    void Start()
    {
        playerCamera = Camera.main;
    }

    void Update()
    {
        var cameraPosition = playerCamera.transform.position;
        cameraPosition.x = player.transform.position.x;
        playerCamera.transform.position = cameraPosition;
    }
}
