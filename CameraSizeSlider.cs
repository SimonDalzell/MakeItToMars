using UnityEngine;
using UnityEngine.UI;

public class CameraSizeSlider : MonoBehaviour
{
    public Slider sizeSlider;

    void Start()
    {
        if (PlayerPrefs.HasKey("CameraSize"))
        {
            float savedSize = PlayerPrefs.GetFloat("CameraSize");
            sizeSlider.value = savedSize;
            UpdateCameraSize(savedSize);
        }

        sizeSlider.onValueChanged.AddListener(UpdateCameraSize);
    }

    void UpdateCameraSize(float newSize)
    {
        Camera.main.orthographicSize = newSize;

        PlayerPrefs.SetFloat("CameraSize", newSize);
        PlayerPrefs.Save();
    }
}
