using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour {
    public string mainMenu;
    public bool isPaused;
    public GameObject pauseMenu;

	// Update is called once per frame
	void Update () {
        if (isPaused)
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
            isPaused = !isPaused;
	}

    public void ResumeGame()
    {
        isPaused = false;
    }

    public void QuitGame()
    {
        Application.LoadLevel(1);
    }

    public void OptionPage()
    {
        Application.LoadLevel(3);
    }

    public void RestartLevel()
    {
        Application.LoadLevel(10);
    }

    public void setActive()
    {
        if (isPaused)
            isPaused = false;
        else
            isPaused = true;
    }
}
