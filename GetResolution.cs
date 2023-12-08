using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetResolution : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Get the screen width and height
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;

        // Calculate the aspect ratio
        float aspectRatio = screenWidth / screenHeight;

        // Log the information
        Camera.main.orthographicSize = Mathf.PI / aspectRatio;


    }
}
