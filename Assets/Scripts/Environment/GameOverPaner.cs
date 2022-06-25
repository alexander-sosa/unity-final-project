using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverPaner : MonoBehaviour
{
    public static GameOverPaner  Instance;

    public GameObject panel;

    void Start()
    {
        Instance = this;
        panel.SetActive(false);
    }

    public void OpenPanel()
    {
        panel.SetActive(true);
            
    }

    public void ClosePanel()
    {
        panel.SetActive(false);
            
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
            
    }

}
