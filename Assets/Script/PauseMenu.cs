using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool pauseState=false;
    public GameObject menuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseState)
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
        menuUI.SetActive(false);
        Time.timeScale = 1f;
        pauseState = false;
    }

    void Pause()
    {
        menuUI.SetActive(true);
        Time.timeScale = 0f;
        pauseState = true;
    }

    public void Menu()
    {
        SceneManager.LoadScene("StartUI");
    }

    public void ApplicationQuit()
    {
        Application.Quit();
    }


}
