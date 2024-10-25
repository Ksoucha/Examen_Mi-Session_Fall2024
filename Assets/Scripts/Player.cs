using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;

    void Start()
    {
        
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        Vector3 nextPosition = transform.position;
        nextPosition += new Vector3(x, 0, 0) * Time.deltaTime * speed;
        transform.position = nextPosition;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * 5;
        }
    }
}
