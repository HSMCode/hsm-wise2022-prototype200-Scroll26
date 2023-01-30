using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoSaver : MonoBehaviour
{
    //this script/game object is for storing data between scenes
    //drag InfoSaver Scene in MainMenu Scene or start in InfoSaver Scene to use

    public float volume = 0.5f;
    public float difficulty = 1f;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
