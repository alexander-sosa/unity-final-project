using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStats : MonoBehaviour
{
    public static GameStats Instance;

    [SerializeField] private AudioClip sound;
    [SerializeField] private GameObject player;
    
    [SerializeField] private int notes;
    [SerializeField] private float life;
    private int _tries;
    private float _time;
    private bool _paused;
    
    void Start()
    {
        Instance = this;
        _time = 0.0f;
        _tries = 0;
        _paused = false;
    }

    void Update()
    {
        if (_paused) return;
        
        _time += Time.deltaTime;
        if (life <= 0.0f)
        {
            Camera.main.GetComponent<AudioSource>().PlayOneShot(sound);
            Debug.Log("Dead!");
            _paused = true;
            player.SetActive(false);
            GameOverPaner.Instance.OpenPanel();
        }
    }

    public void Retry()
    {
        Debug.Log("retrying...");
        
        // Reset stats
        AddTry();
        ResetTime();
        SetLife(100);
        _paused = false;
        
        // Reset objects
        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
        camera.transform.position = new Vector3(0.1f, 0.0f, -10.0f);
        player.SetActive(true);
        player.transform.position = new Vector3(-8.21f, 0.0f, 0.0f);
        GameOverPaner.Instance.ClosePanel();
    }

    public int GetNotes()
    {
        return notes;
    }

    public void SetNotes(int found)
    {
        notes = found;
    }

    public void AddNote()
    {
        notes++;
    }

    public float GetLife()
    {
        return life;
    }

    public void ApplyDamage(float damage)
    {
        life -= damage;
    }

    public void SetLife(float newLife)
    {
        life = newLife;
    }

    public int GetTries()
    {
        return _tries;
    }

    public void AddTry()
    {
        _tries++;
    }

    public float GetTime()
    {
        return _time;
    }

    public void ResetTime()
    {
        _time = 0.0f;
    }
}
