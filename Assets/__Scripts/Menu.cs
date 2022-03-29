using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartFunction()
    {
        SceneManager.LoadScene("TutorialScene");
    }

    public void QuitFunction()
    {
        Application.Quit();
    }

    public void TryAgainFunction()
    {
        //SceneManager.LoadScene("Level1");
        //Loads first level after tutorial
    }
}
