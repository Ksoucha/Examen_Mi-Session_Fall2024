using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSpawner : MonoBehaviour
{
    public GameObject spike;
    public Transform spawnPosition;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnSpike), 0, 1f);
    }

    void SpawnSpike()
    {
        Instantiate(spike, spawnPosition.position, Quaternion.identity);
    }
}
