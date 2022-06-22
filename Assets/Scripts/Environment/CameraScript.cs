using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    void Update()
    {
        if (Player != null && Player.transform.position.x > 0)
        {
            Vector3 position = transform.position;
            position.x = Player.transform.position.x;
            transform.position = position;
        }
    }
}
