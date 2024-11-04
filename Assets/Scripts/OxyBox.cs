using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxyBox : MonoBehaviour
{
    public LineRenderer lineRenderer;

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();

        Vector3 origin = transform.position;
        RaycastHit2D result = Physics2D.Raycast(origin, player.transform.position);

        if (result.collider != null)
        {
            Debug.DrawLine(origin, result.point);
            lineRenderer.SetPosition(0, origin);
            lineRenderer.SetPosition(1, player.transform.position);

            player.pv += 10 * Time.deltaTime;
        }
        else
        {
            lineRenderer.enabled = false;
        }
    }
}
