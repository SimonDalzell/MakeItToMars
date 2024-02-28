using UnityEngine;
using UnityEngine.SceneManagement;

public class ResolutionSceneController : MonoBehaviour
{
    private void Start()
    {
        if (PlayerPrefs.HasKey("CameraSize"))
        {
            LoadNextScene();
        }
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
