using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject jumperPrefab;
    float lastSpawnTime;
    [Range(0, 5)]
    public float spawnDelay = 3.0f;
    private float randomDelay;
    [Range(0, 2)]
    public float deltaRandom = 0.5f;

    private void Start()
    {
        if (jumperPrefab != null)
            SpawnJumpter();
        randomDelay = spawnDelay;
    }

    private void Update()
    { 
        if (Time.time > lastSpawnTime + randomDelay)
        {
            SpawnJumpter();
        }
    }

    private void SpawnJumpter()
    {
        Instantiate(jumperPrefab);
        randomDelay = UnityEngine.Random.Range(spawnDelay - deltaRandom, spawnDelay + deltaRandom);
        lastSpawnTime = Time.time;
    }
}
