using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteScript : MonoBehaviour
{

    [SerializeField] private AudioClip sound;
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
            NotePanelController.Instance.showPanel(GetId(), gameObject);
            Debug.Log("Note Found!");
            Camera.main.GetComponent<AudioSource>().PlayOneShot(sound);
            found = true;
            NotesController.Instance.setVisibility(GetId());
            gameObject.SetActive(false);
            GameStats.Instance.AddNote();
            
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
