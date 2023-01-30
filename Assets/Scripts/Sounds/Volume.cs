using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{

    private Slider _volumeSlider;
    private MusicOptions _musicOptionsScript;

    void Start()
    {
        _volumeSlider = GetComponent<Slider>();
        _musicOptionsScript = GameObject.Find("MenuMusic").GetComponent<MusicOptions>();
    }

    void Update()
    {
        _musicOptionsScript.volume = _volumeSlider.value;
    }
}
