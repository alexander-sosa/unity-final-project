using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void ControlsButton()
    {
        SceneManager.LoadScene("ControlsMenu");

    }

    public void ExitButton()
    {
        Debug.Log("Salir del juego");
    }

    public void ControlsButtonBack()
    {
        SceneManager.LoadScene("MainMenu");

    }
}
