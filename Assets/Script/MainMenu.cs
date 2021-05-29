using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public static bool gameIsPaused = false;
    GameObject PauseUI;

    public void PlayGame()

    {
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    } 

    public void Options()
    {
        SceneManager.LoadScene("Options");
    }

    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }


//Menu Pause
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(gameIsPaused)
            {
                Resume();
            }
            else
            {
                Paused();
            }
    }

}

void Paused()
{
    PauseUI.SetActive(true);
    Time.timeScale = 0;
    gameIsPaused = true;
}

void Resume()
{
    PauseUI.SetActive(false);
    Time.timeScale = 1;
    gameIsPaused = false;
}

}
