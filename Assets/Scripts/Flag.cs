using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Flag : MonoBehaviour
{
    public TMP_Text winText;

    void Start()
    {
        winText.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();

        if (player != null )
        {
            winText.enabled = true;
        }
    }
}
