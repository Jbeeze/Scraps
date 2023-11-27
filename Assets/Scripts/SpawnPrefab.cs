using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnPrefab : MonoBehaviour
{

    public GameObject prefab;
    public List<GameObject> prefabsToSpawn;
    public string itemTag = "Good_Item";
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
        GameObject[] spawnPoints = GameObject.FindGameObjectsWithTag(itemTag);
        float x = Random.Range(minX, maxX);
        float y = Random.Range(minY, maxY);
        int randomPrefab = Random.Range(0, prefabsToSpawn.Count);
        Instantiate(prefabsToSpawn[randomPrefab], new Vector2(x, y), Quaternion.identity);
    }
}
