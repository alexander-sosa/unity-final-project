using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolsSpawner : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private AudioClip sound;
    
    [SerializeField] private GameObject bridge;
    [SerializeField] private float bridgeX;
    [SerializeField] private GameObject stairs;
    [SerializeField] private float stairsX;

    private bool _bridged = false;
    private bool _staired = false;

    void Update()
    {
        if (player == null) return;
        
        if (player.transform.position.x >= bridgeX - 2.0f && !_bridged)
        {
            Camera.main.GetComponent<AudioSource>().PlayOneShot(sound);
            Instantiate(bridge, new Vector3(bridgeX, 6.5f), Quaternion.identity);
            _bridged = true;
        }

        if (player.transform.position.x >= stairsX - 2.0f && !_staired)
        {
            Instantiate(stairs, new Vector3(stairsX, 6.5f), Quaternion.identity);
            _staired = true;
        }
    }
}
