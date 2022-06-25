using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;

public class NotesController : MonoBehaviour
{
    public static NotesController Instance;
    public Sprite note;
    public Sprite noteLock;

    public GameObject[] Notes;
    int index;
    bool[] visibility = new bool[]{false, false, false, false, false, false };

    void Start()
    {
        Instance = this;
        CreateTextFile();
        changeImages();
        
        
    }

    public bool[] getVisibility(){
        return visibility;
    }

    public void setVisibility(int p){
        visibility[p] = true;
        UpdateText();
    }


    public void CreateTextFile()
    {
        string txtNotesName = Application.streamingAssetsPath + "/Notes/" + "SaveNotes" + ".txt";                         
        if (!File.Exists(txtNotesName))
        {
            for (int i = 0; i < getVisibility().Length; i++)
            {
                //Debug.Log(getVisibility()[i]);
                File.AppendAllText(txtNotesName, getVisibility()[i] + "\n");
            }            
            
        }else
        {
            string rffp = Application.streamingAssetsPath + "/Notes/" + "SaveNotes" + ".txt";                         

            List<string> fileLines = File.ReadAllLines(rffp).ToList();

            index = 0;

            foreach (var line in fileLines)
            {         
                Debug.Log(line);
                if(line == "False"){
                    visibility[index] = false;
                }else{
                    visibility[index] = true;
                }
                
                index++;  
                
                
            }
        }
    }

    public void changeImages()
    {
        for (int i = 0; i < Notes.Length; i++)
        {
            if(getVisibility()[i] == true){
                Notes[i].GetComponent<Image>().sprite = note; 
                Notes[i].GetComponent<Image>().color = Color.black;
                //Notes[i].gameObject.active = true;
            }else
            {
                Notes[i].GetComponent<Image>().sprite = noteLock; 
                Notes[i].GetComponent<Image>().color = Color.white;
                //Notes[i].gameObject.active = false;
            }
        }
    }

    // Update is called once per frame
    public void UpdateText()
    {
        string txtNotesName = Application.streamingAssetsPath + "/Notes/" + "SaveNotes" + ".txt";                         
        if (!File.Exists(txtNotesName))
        {
            for (int i = 0; i < getVisibility().Length; i++)
            {
                //Debug.Log(getVisibility()[i]);
                File.AppendAllText(txtNotesName, getVisibility()[i] + "\n");
            }            
            
        }else
        {
            File.WriteAllText(txtNotesName, "");
            for (int i = 0; i < getVisibility().Length; i++)
            {
                //Debug.Log(getVisibility()[i]);
                File.AppendAllText(txtNotesName, getVisibility()[i] + "\n");
            }  
        }
    }
}
