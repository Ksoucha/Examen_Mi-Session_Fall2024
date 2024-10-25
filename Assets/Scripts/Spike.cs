using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public float speed = 7f;

    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * speed);
    }
}
