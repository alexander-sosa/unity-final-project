using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transitions : MonoBehaviour
{
    private Animator _transitionAni;

    void Start()
    {
        _transitionAni = GetComponent<Animator>() ;
    }

    public void LoadScene(string scene)
    {
        StartCoroutine(Transition(scene));
    
    }
    IEnumerator Transition(string scene)
    {
        _transitionAni.SetTrigger("quit");
        yield return new WaitForSeconds(1);
        LoadScene(scene);
    }
}
