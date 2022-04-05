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

    public void Levels()
    {
        SceneManager.LoadScene("Levels");
    }

    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void Level3()
    {
        SceneManager.LoadScene("Level3");
    }

    public void Level4()
    {
        SceneManager.LoadScene("Level4");
    }

    public void Training()
    {
        SceneManager.LoadScene("TutorialScene");
    }
}
