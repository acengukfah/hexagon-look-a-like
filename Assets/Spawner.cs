using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public float spawnRate = 1f;
    public GameObject hexagonPrefab;
    private float nextTimeToSpawn = 0f;
    public float levelHardenes = 0.99f;

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextTimeToSpawn)
        {
            Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);
            nextTimeToSpawn = Time.time + 1f / spawnRate;
            spawnRate = spawnRate / levelHardenes;
        }
    }
}
