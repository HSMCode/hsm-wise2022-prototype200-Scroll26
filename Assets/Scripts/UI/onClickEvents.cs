using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onClickEvents : MonoBehaviour
{

    public GameObject pauseMenu;
    public GameObject optionsMenu;
    private string _sceneName;


    private void Start() 
    {
        Scene currentScene = SceneManager.GetActiveScene();
        _sceneName = currentScene.name;
    }

    private void Update() 
    {
        if (_sceneName == "MainMenu")
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                optionsMenu.SetActive(false);
            } 
            
        }
    }

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

    public void Options() 
    {
        optionsMenu.SetActive(true);
    }

    public void Close() 
    {
        optionsMenu.SetActive(false);
    }
}
