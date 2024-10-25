using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;

    public TMP_Text pvText;
    public float pv;

    void Start()
    {
        pvText.text = "PV : 100";
        pv = 100;
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

        pv -= 1 * Time.deltaTime;
        pvText.text = "PV : " + Mathf.Round(pv);
    }
}
