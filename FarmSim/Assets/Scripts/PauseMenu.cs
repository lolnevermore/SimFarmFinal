using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class PauseMenu : MonoBehaviour
{
    public static bool IsPaused = false;
    public GameObject PauseUI;
    public GameObject SettingsUI;
    public AudioMixer MasterMixer;
    public AudioMixer SFXMixer;

    private void Start()
    {
        PauseUI = GameObject.Find("PauseUI");
        PauseUI.SetActive(false);
        SettingsUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
        IsPaused = false;
    }

    public void Pause()
    {
        PauseUI.SetActive(true);
        Time.timeScale = 0f;
        IsPaused = true;
    }

    public void Settings()
    {
        SettingsUI.SetActive(true);
    }

    public void ReturntoPause()
    {
        SettingsUI.SetActive(false);
    }

    public void QuitToMain()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }


    public void SetVolumeMaster (float volumeM)
    {
        MasterMixer.SetFloat("MasterVolume", volumeM);
    }

    public void SetVolumeSFX (float volumeS)
    {
        SFXMixer.SetFloat("SFXVolume", volumeS);
    }
}
