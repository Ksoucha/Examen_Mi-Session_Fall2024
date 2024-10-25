using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melon : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();

        if (player.pv <= 80)
        {
            player.pv += 20;
            Destroy(gameObject);
        }
        else
        {
            player.pv = 100;
            Destroy(gameObject);
        }
    }
}
