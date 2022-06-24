using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;

public class PanelController : MonoBehaviour
{
    public GameObject Button;
    public GameObject Panel;
    public GameObject NoteText;
    
    public Sprite note;
    public Sprite noteLock;
    
    private string txt;
    private string currentNote;
    
    public void OpenPanel()
    {
        //Debug.Log(Button.GetComponent<Image>().sprite);
        //Debug.Log(Button.name);

        //Debug.Log(numNote[1]);

        if (Button.GetComponent<Image>().sprite == note)
        {
            if (Panel != null)
        {
            Panel.SetActive(true);
            string name = Button.name;
            string[] numNote;
            numNote = name.Split(char.Parse("_"));
                
            txt = "";
            NoteText.GetComponent<Text>().text = "";

            string rffp = Application.streamingAssetsPath + "/Notes/" + "nota"+ numNote[1] + ".txt";                         

            List<string> fileLines = File.ReadAllLines(rffp).ToList();

            foreach (var line in fileLines)
            {           
                txt += line + "\n";
                
            }

            //print("Fuera> "+txt);
            NoteText.GetComponent<Text>().text = txt;
            
            
        }
            
        }
        /*
        if (Panel != null)
        {
            Panel.SetActive(true);

            if(NoteText.GetComponent<Text>().text == ""){
                string rffp = Application.streamingAssetsPath + "/notes/" + "nota1" + ".txt";

                List<string> fileLines = File.ReadAllLines(rffp).ToList();

                foreach (var line in fileLines)
                {           
                    txt += line + "\n";
                    
                }

                //print("Fuera> "+txt);
                NoteText.GetComponent<Text>().text = txt;
            }else{
                print(NoteText.GetComponent<Text>().text);
            }
            
        }*/
    }

    public void ClosePanel()
    {
        if (Panel != null)
        {
            txt = "";
            NoteText.GetComponent<Text>().text = "";
            Panel.SetActive(false);
            
        }
    }
}
