using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeethSpawner : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject teeth;
    [SerializeField] private float timeToSpawn;
    [SerializeField] private int teethToInstantiate;

    private float _timeToSpawnAux;
        
    void Start()
    {
        _timeToSpawnAux = timeToSpawn;
    }

    void Update()
    {
        if (player.transform.position.x > 20.0f)
        {
            timeToSpawn -= Time.deltaTime;
            if (timeToSpawn <= 0.0f)
            {
                for(int i = 0; i<teethToInstantiate; i++)
                {
                    Instantiate(
                        teeth, 
                        new Vector3(
                            Random.Range(
                                player.transform.position.x - 2.0f, 
                                player.transform.position.x + 2.0f
                            ), 
                            Random.Range(5.5f, 7.5f)), 
                        Quaternion.identity
                    );
                }

                timeToSpawn = _timeToSpawnAux;
            }
        }
    }
}
