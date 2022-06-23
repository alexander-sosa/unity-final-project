using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject player;

    [SerializeField] private GameObject enemy1Prefab;
    [SerializeField] private int instances1;
    [SerializeField] private float timeToSpawn1;
    private int _instances1Aux;
    private float _timeToSpawn1Aux;

    [SerializeField] private GameObject enemy2Prefab;
    [SerializeField] private int instances2;
    [SerializeField] private float timeToSpawn2;
    private int _instances2Aux;
    private float _timeToSpawn2Aux;

    
    void Start()
    {
        _instances1Aux = instances1;
        _timeToSpawn1Aux = timeToSpawn1;
        _instances2Aux = instances2;
        _timeToSpawn2Aux = timeToSpawn2;
    }

    void Update()
    {
        // Enemies 1
        if (player.transform.position.x >= 23)
        {
            timeToSpawn1 -= Time.deltaTime;
            if (timeToSpawn1 <= 0 && instances1 > 0)
            {
                Instantiate(enemy1Prefab, new Vector3(26.5f, 3.5f), Quaternion.identity);
                timeToSpawn1 = _timeToSpawn1Aux;
                instances1--;
            }
        }
        
        // Enemies 2
        if (player.transform.position.x >= 30)
        {
            timeToSpawn2 -= Time.deltaTime;
            if (timeToSpawn2 <= 0 && instances2 > 0)
            {
                Instantiate(enemy2Prefab, new Vector3(40.0f, 4.0f), Quaternion.identity);
                timeToSpawn2 = _timeToSpawn2Aux;
                instances2--;
            }
        }
    }
}
