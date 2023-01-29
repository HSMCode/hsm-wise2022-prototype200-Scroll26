using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundaries : MonoBehaviour
{
    private Vector3 screenBounds;
    private float objectWidth;
    private float objectHeigth;


    void Start()
    {
        //Get Bounds Size from Camera
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Camera.main.transform.position.y, Screen.height));

        //Get Object Width and Height from Little Soul Game Object 
        objectWidth = GameObject.Find("Little_Soul").transform.GetComponent<SpriteRenderer>().bounds.size.x;
        objectHeigth = GameObject.Find("Little_Soul").transform.GetComponent<SpriteRenderer>().bounds.size.z;   
    }


    void LateUpdate()
    {
        //Clamp Bounds to prevent going out of bounds 
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x * -1, screenBounds.x - objectWidth / 2);
        viewPos.z = Mathf.Clamp(viewPos.z, screenBounds.z + objectHeigth / 2, screenBounds.z * -1 - objectHeigth);
        transform.position = viewPos;
    }
}
