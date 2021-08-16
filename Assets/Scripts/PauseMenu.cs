using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject mainUI;
    public GameObject pauseUI;
    public GameObject mixerCanvas;

    public void pauseBtn()
    {
        Time.timeScale = 0;
        mainUI.SetActive(false);
        pauseUI.SetActive(true);
    }

    public void resumeBtn()
    {
        Time.timeScale = 1;
        pauseUI.SetActive(false);
        mainUI.SetActive(true);
    }

    public void mainMenuBtn()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }

    public void mixersBtn()
    {
        pauseUI.SetActive(false);
        mixerCanvas.SetActive(true);
    }

    public void mixersBackBtn()
    {
        mixerCanvas.SetActive(false);
        pauseUI.SetActive(true);
    }

    public void restartLevel()
    {
        if (Time.timeScale != 1)
        {
            Time.timeScale = 1;
        }
        SceneManager.LoadScene(1);
    }

    public void quitbtn()
    {
        Application.Quit();
    }
}
