using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenuCanvas;
    public GameObject mixersCanvas;
    public GameObject settingsCanvas;

    public void startBtn()
    {
        SceneManager.LoadScene(sceneBuildIndex:1);
    }

    public void mixersBtn()
    {
        mainMenuCanvas.SetActive(false);
        mixersCanvas.SetActive(true);
    }

    public void mixersBackBtn()
    {
        mixersCanvas.SetActive(false);
        mainMenuCanvas.SetActive(true);
    }

    public void SettingsBtn()
    {
        mainMenuCanvas.SetActive(false);
        settingsCanvas.SetActive(true);
    }

    public void quitBtn()
    {
        Application.Quit();
    }

    #region Website Links
    public void facebookBtn()
    {
        Application.OpenURL("https://www.facebook.com/AbstinenceSpirit/?ref=br_rs");
    }

    public void instagram()
    {
        Application.OpenURL("https://www.instagram.com/abstinencespirit/");
    }

    public void learnMoreBtn()
    {
        Application.OpenURL("https://ashjugdav.wixsite.com/abstinencetestsite");
    }

    #endregion
}
