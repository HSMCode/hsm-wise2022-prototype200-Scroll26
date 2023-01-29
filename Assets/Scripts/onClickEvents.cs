using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onClickEvents : MonoBehaviour
{

    public GameObject pauseMenu;


    public void restartGame()
    {
        SceneManager.LoadScene("ErsterAnlauf");
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Resume()
    {
        //unpause the time
        Time.timeScale = 1;
        //and hide the pause menu panel
        pauseMenu.SetActive(false);
    }
}
