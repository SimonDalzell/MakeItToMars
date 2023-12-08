using UnityEngine;
using UnityEngine.UI;

public class CameraSizeSlider : MonoBehaviour
{
    public Slider sizeSlider;

    void Start()
    {
        // Check if the camera size is already set in PlayerPrefs
        if (PlayerPrefs.HasKey("CameraSize"))
        {
            float savedSize = PlayerPrefs.GetFloat("CameraSize");
            sizeSlider.value = savedSize;
            UpdateCameraSize(savedSize);
        }

        // Add a listener to the slider's value change event
        sizeSlider.onValueChanged.AddListener(UpdateCameraSize);
    }

    void UpdateCameraSize(float newSize)
    {
        // Set the new size of the camera
        Camera.main.orthographicSize = newSize;

        // Save the new size to PlayerPrefs for persistence across scenes
        PlayerPrefs.SetFloat("CameraSize", newSize);
        PlayerPrefs.Save();
    }
}
