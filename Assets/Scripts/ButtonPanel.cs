using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPanel : MonoBehaviour
{
    public GameObject btnQuitar;
    public GameObject panel;
    public GameObject text;
    private string txt;

    public void ClosePanel()
    {
            txt = "";
            text.GetComponent<Text>().text = "";
            panel.SetActive(false);
            
    }
}
