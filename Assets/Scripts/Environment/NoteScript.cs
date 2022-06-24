using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteScript : MonoBehaviour
{
    [SerializeField] private bool found;
    [SerializeField] private int id;
    
    void Start()
    {
        found = false;
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("Note Found!");
            found = true;
            gameObject.SetActive(false);
        }
    }

    public bool IsFound()
    {
        return found;
    }

    public void SetFound(bool wasFound)
    {
        found = wasFound;
    }

    public int GetId()
    {
        return id;
    }
}