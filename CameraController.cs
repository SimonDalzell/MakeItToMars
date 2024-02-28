using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float newSize = 5f;

    void Start()
    {
        if (PlayerPrefs.HasKey("CameraSize"))
        {
            newSize = PlayerPrefs.GetFloat("CameraSize");
        }

        ChangeCameraSize(newSize);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            newSize = Random.Range(3f, 10f); 
            ChangeCameraSize(newSize);
        }
    }

    void ChangeCameraSize(float newSize)
    {
        Camera.main.orthographicSize = newSize;

        PlayerPrefs.SetFloat("CameraSize", newSize);
        PlayerPrefs.Save();
    }
}
