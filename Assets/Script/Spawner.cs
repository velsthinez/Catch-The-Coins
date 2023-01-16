using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public GameObject CoinPrefab;
    public GameObject RareCoinPrefab;

    public Vector2 MinMaxPos;

    public float RareSpawnChance = 0.1f;
    
    public float SpawnInterval = 1f;
    
    public bool isSpawning = false;

    public float spawnTimer;

    private void Start()
    {
        spawnTimer = SpawnInterval;
    }

    // Update is called once per frame
    void Update()
    {
        // if (isSpawning)
        //     return;

        if (spawnTimer > 0)
        {
            spawnTimer -= Time.deltaTime;
            // isSpawning = false;
        }
        else
        {
            float diceroll = Random.Range(0f, 100f);
            
            if(diceroll <= RareSpawnChance)
            {
                GameObject.Instantiate(RareCoinPrefab,new Vector3(Random.Range(MinMaxPos.x, MinMaxPos.y), transform.position.y, transform.position.z),
                    Quaternion.Euler(0,0, Random.Range(-360,360) ));}
            
            else
            {
                GameObject.Instantiate(CoinPrefab,new Vector3(Random.Range(MinMaxPos.x, MinMaxPos.y), transform.position.y, transform.position.z),
                    Quaternion.Euler(0,0, Random.Range(-360,360) ));
            }

            // isSpawning = true;
            spawnTimer = SpawnInterval;
        }
    }
}
