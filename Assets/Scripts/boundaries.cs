using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundaries : MonoBehaviour
{
    private Vector3 _screenBounds;
    private float _objectWidth;
    private float _objectHeigth;


    void Start()
    {
        //Get Bounds Size from Camera
        _screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Camera.main.transform.position.y, Screen.height));

        //Get Object Width and Height from Little Soul Game Object 
        _objectWidth = GameObject.Find("Little_Soul").transform.GetComponent<SpriteRenderer>().bounds.size.x;
        _objectHeigth = GameObject.Find("Little_Soul").transform.GetComponent<SpriteRenderer>().bounds.size.z;   
    }


    void LateUpdate()
    {
        //Clamp Bounds to prevent going out of bounds 
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, _screenBounds.x * -1, _screenBounds.x - _objectWidth / 2);
        viewPos.z = Mathf.Clamp(viewPos.z, _screenBounds.z + _objectHeigth / 2, _screenBounds.z * -1 - _objectHeigth);
        transform.position = viewPos;
    }
}
