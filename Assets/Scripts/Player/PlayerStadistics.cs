using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerStadistics : MonoBehaviour
{
    [SerializeField] private Text time;
    [SerializeField] private Text life;
    [SerializeField] private Text notes;

    // Start is called before the first frame update
    void Start()
    {
        time.text = "Tiempo: "+ GameStats.Instance.GetTime().ToString();
        life.text +=  " "+ GameStats.Instance.GetLife()+ " %";
        notes.text +=  " "+ GameStats.Instance.GetNotes();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
