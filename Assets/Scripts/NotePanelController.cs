using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;

public class NotePanelController : MonoBehaviour
{
    public static NotePanelController Instance;

    private string txt;
    int index;
    public float speed;

    //public GameObject btnQuitar;
    public GameObject panel;
    public GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        panel.SetActive(false);
    }

   /* // Update is called once per frame
    void Update()
    {
        if(text.text == txt[index])
        {

        }
    }*/

    IEnumerator TxtPanel(int id, GameObject obj)
    {
            
        txt = "";
        text.GetComponent<Text>().text = "";

        Debug.Log(id);
        string rffp = Application.streamingAssetsPath + "/Notes/" + "nota"+ id + ".txt";                         

        List<string> fileLines = File.ReadAllLines(rffp).ToList();

        foreach (var line in fileLines)
        {           
            txt += line + "\n";
            
        }

        foreach (var letra in txt.ToCharArray())
        {
            text.GetComponent<Text>().text += letra;
            yield return new WaitForSeconds(speed);
        }
        //obj.SetActive(false);

        
    }

    public void showPanel(int id, GameObject obj)
    {
        panel.SetActive(true);
        StartCoroutine(TxtPanel(id, obj));
    }

    public void ClosePanel()
    {
            txt = "";
            text.GetComponent<Text>().text = "";
            panel.SetActive(false);
            
    }
}
