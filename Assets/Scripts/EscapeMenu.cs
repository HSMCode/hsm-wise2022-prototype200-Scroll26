using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeMenu : MonoBehaviour
{

    public GameObject pauseMenu;

    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //pause the time
            Time.timeScale = 0;
            //and show the pause menu panel
            pauseMenu.SetActive(true);
        }
        
    }
}
