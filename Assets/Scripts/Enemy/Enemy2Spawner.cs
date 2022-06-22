using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Spawner : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject enemy2Prefab;
    [SerializeField] private int instances;
    [SerializeField] private float timeToSpawn;

    private int _instancesAux;
    private float _timeToSpawnAux;
    
    void Start()
    {
        _instancesAux = instances;
        _timeToSpawnAux = timeToSpawn;
    }

    void Update()
    {
        timeToSpawn -= Time.deltaTime;
        if (player.transform.position.x >= 23 && timeToSpawn <= 0 && instances > 0)
        {
            Instantiate(enemy2Prefab, new Vector3(26.5f, 3.5f), Quaternion.identity);
            timeToSpawn = _timeToSpawnAux;
            instances--;
        }
    }
}
