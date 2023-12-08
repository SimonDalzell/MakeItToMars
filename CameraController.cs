using UnityEngine;

public class CameraController : MonoBehaviour
{
    // New size for the camera
    public float newSize = 5f;

    void Start()
    {
        // Check if the camera size is already set in PlayerPrefs
        if (PlayerPrefs.HasKey("CameraSize"))
        {
            newSize = PlayerPrefs.GetFloat("CameraSize");
        }

        // Set the initial size of the camera
        ChangeCameraSize(newSize);
    }

    void Update()
    {
        // Check for user input or any other conditions to change the size
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Change the size of the camera
            newSize = Random.Range(3f, 10f); // Just an example, you can set newSize based on your conditions
            ChangeCameraSize(newSize);
        }
    }

    void ChangeCameraSize(float newSize)
    {
        // Set the new size of the camera
        Camera.main.orthographicSize = newSize;

        // Save the new size to PlayerPrefs for persistence across scenes
        PlayerPrefs.SetFloat("CameraSize", newSize);
        PlayerPrefs.Save();
    }
}
