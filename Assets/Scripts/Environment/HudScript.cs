using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudScript : MonoBehaviour
{
    [SerializeField] private Text life;
    [SerializeField] private Text notes;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        life.text =  "Vida "+ GameStats.Instance.GetLife().ToString()+ " %";
        //notes.text =  " "+ GameStats.Instance.GetNotes()+ " /6";
        Debug.Log(GameStats.Instance.GetLife());
    }
}
