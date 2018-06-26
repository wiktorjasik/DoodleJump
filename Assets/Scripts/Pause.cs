using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {

    public GameObject pauseButton;
    public GameObject pauseMenu;
    public GameObject leftButton, rightButton;

    public void PauseStart()
    {
        pauseMenu.SetActive(true);
        pauseButton.SetActive(false);
        if (Application.platform == RuntimePlatform.Android)
        {
            rightButton.SetActive(false);
            leftButton.SetActive(false);
        }
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        pauseButton.SetActive(true);
        if (Application.platform == RuntimePlatform.Android)
        {
            rightButton.SetActive(true);
            leftButton.SetActive(true);
        }
        Time.timeScale = 1f;
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
        Resume();
    }
}
