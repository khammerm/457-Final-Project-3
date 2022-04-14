using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartFunction()
    {
        SceneManager.LoadScene("Level_Demo");
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

    public void Training()
    {
        SceneManager.LoadScene("Loading_Demo");
    }

    public void Levels()
    {
        SceneManager.LoadScene("Levels");
    }

    public void Level1()
    {
        SceneManager.LoadScene("Loading_Run");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Loading_Jumping");
    }

    public void Level3()
    {
        SceneManager.LoadScene("Maze");
    }

    public void Level4()
    {
        SceneManager.LoadScene("Loading_Practice");
    }

    public void MazeLevel()
    {
        SceneManager.LoadScene("Maze");
    }

    public void DemoLevel()
    {
        SceneManager.LoadScene("Level_Demo");
    }

    public void JumpingLevel()
    {
        SceneManager.LoadScene("Jumping_Puzzle");
    }

    public void RunLevel()
    {
        SceneManager.LoadScene("Target_Run");
    }

    public void PracticeLevel()
    {
        SceneManager.LoadScene("Target_Practice");
    }

    public void MazeLoad()
    {
        SceneManager.LoadScene("Loading_Maze");
    }


    //wait function here



}
