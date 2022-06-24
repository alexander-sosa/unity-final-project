using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalPanel : MonoBehaviour
{
    public static FinalPanel Instance;

    [SerializeField] private InputField resp;
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject panelStatic;
    [SerializeField] private AudioClip sound;
    private string guest;

    void Start()
    {
        Instance = this;
        panel.SetActive(false);
        panelStatic.SetActive(false);
    }

    public void OpenPanel()
    {
        panel.SetActive(true);
            
    }

    public void ClosePanel()
    {
        panel.SetActive(false);
            
    }

    public void SendResp()
    {
        guest = resp.text;
        if(guest.ToLower() == "alarma"){
            Debug.Log("rigth");
            Camera.main.GetComponent<AudioSource>().PlayOneShot(sound);
            panelStatic.SetActive(true);

        }else{
            Debug.Log("bad");
        }
    }


}
