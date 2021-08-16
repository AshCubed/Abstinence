using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsScript : MonoBehaviour
{
    public GameObject mainMenuCanvas;
    public GameObject settingsCanvas;

    public AudioMixer audioMixer;

    public void backBtn()
    {
        settingsCanvas.SetActive(false);
        mainMenuCanvas.SetActive(true);
    }

    public void setVolume(float volume) => audioMixer.SetFloat("volume", volume);
}
