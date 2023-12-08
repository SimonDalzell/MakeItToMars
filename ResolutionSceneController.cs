using UnityEngine;
using UnityEngine.SceneManagement;

public class ResolutionSceneController : MonoBehaviour
{
    private void Start()
    {
        // Check if the player preference for resolution exists
        if (PlayerPrefs.HasKey("CameraSize"))
        {
            // If it exists, the resolution has been set, so go to the next scene
            LoadNextScene();
        }
    }

    private void LoadNextScene()
    {
        // Replace "YourNextSceneName" with the actual name of your next scene
        SceneManager.LoadScene("MainMenu");
    }
}
