using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnPrefab : MonoBehaviour
{

    public GameObject prefab;
    public float maxX;
    public float maxY;
    public float minX;
    public float minY;
    public float TimeBetweenSpawn;
    private float SpawnTime;
    
    
    void Update()
    {
        if (Time.time > SpawnTime)
        {
            Spawn();
            SpawnTime=Time.time + TimeBetweenSpawn;
        }
    }

    public void Spawn() 
    {
        float x = Random.Range(minX, maxX);
        float y = Random.Range(minY, maxY);
        Instantiate(prefab, new Vector2(x, y), Quaternion.identity);
    }
}
