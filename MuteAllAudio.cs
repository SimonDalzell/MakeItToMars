using UnityEngine;
using UnityEngine.UI;

public class MuteAllAudio : MonoBehaviour
{
    private bool isMuted = false;

    void Start()
    {
        // Ensure the AudioManager persists across scenes
        DontDestroyOnLoad(gameObject);
    }

    public void ToggleMute()
    {
        isMuted = !isMuted;

        // Find all AudioSources in the scene
        AudioSource[] audioSources = FindObjectsOfType<AudioSource>();

        // Mute or unmute each AudioSource
        foreach (AudioSource audioSource in audioSources)
        {
            audioSource.mute = isMuted;
        }
    }
}
