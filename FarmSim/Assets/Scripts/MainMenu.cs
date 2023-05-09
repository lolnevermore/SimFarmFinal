using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator transitionAnim;
    public string SceneName;
    public GameObject transitionScreen;

    private void Start()
    {
        Time.timeScale = 1f;
        transitionScreen = GameObject.Find("ScreenTran");
        transitionScreen.SetActive(false);
    }
    public void startGame()
    {
        //transitionAnim.SetTrigger("end");
        //SceneManager.LoadScene("SampleScene");
        SceneName = "SampleScene";
        StartCoroutine(LoadScene());
    }

    public void settings()
    {
        //transitionAnim.SetTrigger("end");
        //SceneManager.LoadScene("Settings");
        SceneName = "Settings";
        StartCoroutine(LoadScene());
    }

    public void returnToMain()
    {
        //transitionAnim.SetTrigger("end");
        //SceneManager.LoadScene("Main Menu");
        SceneName = "Main Menu";
        StartCoroutine(LoadScene());
    }

    public void quitGame()
    {
        Application.Quit();
    }

    IEnumerator LoadScene()
    {
        transitionScreen.SetActive(true);
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(SceneName);
    }
}
