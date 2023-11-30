using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnPrefab : MonoBehaviour
{

    public GameObject prefab;
    public List<GameObject> prefabsToSpawn;
    public string goodItem = "Good_Item";
    public string badItem = "Bad_Item";
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
        GameObject[] goodItems = GameObject.FindGameObjectsWithTag(goodItem);
        GameObject[] badItems = GameObject.FindGameObjectsWithTag(goodItem);
        float x = Random.Range(minX, maxX);
        float y = Random.Range(minY, maxY);
        int randomPrefab = Random.Range(0, prefabsToSpawn.Count);
        Instantiate(prefabsToSpawn[randomPrefab], new Vector2(x, y), Quaternion.identity);
    }
}
