using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSpawner : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject brick1;
    [SerializeField] private GameObject brick2;
    [SerializeField] private GameObject brick3;
    [SerializeField] private float timeToSpawn;

    private List<GameObject> _bricks;
    private float _timeToSpawnAux;
    private int _bricksToInstantiate;
        
    void Start()
    {
        _bricks = new List<GameObject>
        {
            brick1,
            brick2,
            brick3
        };
        _timeToSpawnAux = timeToSpawn;
        _bricksToInstantiate = 3;
    }

    void Update()
    {
        if (player.transform.position.x > 20.0f)
        {
            timeToSpawn -= Time.deltaTime;
            if (timeToSpawn <= 0.0f)
            {
                for(int i = 0; i<_bricksToInstantiate; i++)
                {
                    Instantiate(
                        _bricks[Random.Range(0, _bricks.Count)], 
                        new Vector3(player.transform.position.x, 6.5f), 
                        Quaternion.identity
                    );
                }

                timeToSpawn = _timeToSpawnAux;
            }
        }
    }
}
