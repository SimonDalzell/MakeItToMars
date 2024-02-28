using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetResolution : MonoBehaviour
{
    void Start()
    {
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;

        float aspectRatio = screenWidth / screenHeight;

        Camera.main.orthographicSize = Mathf.PI / aspectRatio;


    }
}
