using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseHandler : MonoBehaviour
{
    public GameObject pausePanel;  // the pause menu panel that will be activated
    public GameObject[] objectsToDeactivateOnPause;  // objects that should be inactive when paused, and active otherwise

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
        bool isPaused = !pausePanel.activeSelf;
        
        if(isPaused)
            Pause();
        else
            Resume();

        pausePanel.SetActive(isPaused);       
    }

    void Pause()
    {
        // deactivates all objects that should be deactivated when the game is paused, and sets the Time.timeScale to 0
        SetGameObjectListActiveState(false);
        Time.timeScale = 0f;
    }

    void Resume()
    {
        // reactivates any object that was deactivated by the pause menu, and sets the Time.timeScale back to normal (1)
        SetGameObjectListActiveState(true);
        Time.timeScale = 1f;
    }

    void SetGameObjectListActiveState(bool active)
    {
        foreach(GameObject gameObject in objectsToDeactivateOnPause) {
            gameObject.SetActive(active);
        }
    }
