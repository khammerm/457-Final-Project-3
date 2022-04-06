using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseHandler : MonoBehaviour
{
    public GameObject pausePanel;  // the pause menu panel that will be activated

    // Start is called before the first frame update
    void Start()
    {
        pausePanel.SetActive(false);  // don't start off in the pause menu by default lol
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    void TogglePause()
    {
        // FIXME: Weapons consume ammo and perform shooting raycasting while in pause menu

        bool isPaused = !pausePanel.activeSelf;
        
        if(isPaused)
            Time.timeScale = 0f;
        else
            Time.timeScale = 1f; 

        pausePanel.SetActive(isPaused);       
    }
}
