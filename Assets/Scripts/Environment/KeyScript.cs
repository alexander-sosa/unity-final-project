using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    [SerializeField] private AudioClip sound;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("Enter key...");
            // if key == okay
            // Camera.main.GetComponent<AudioSource>().PlayOneShot(sound);
        }
    }
}
