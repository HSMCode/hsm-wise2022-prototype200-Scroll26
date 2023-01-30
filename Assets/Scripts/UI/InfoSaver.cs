using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoSaver : MonoBehaviour
{
    //this script/game object is for storing data between scenes

    public float volume = 0.5f;
    public float difficulty = 1f;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
