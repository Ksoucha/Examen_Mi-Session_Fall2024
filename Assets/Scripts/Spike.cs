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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();
      
        player.pv -= 20;
        Destroy(gameObject);
    }
}
