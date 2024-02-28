using UnityEngine;
using UnityEngine.UI;

public class MuteAllAudio : MonoBehaviour
{
    private bool isMuted = false;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void ToggleMute()
    {
        isMuted = !isMuted;

        AudioSource[] audioSources = FindObjectsOfType<AudioSource>();

        foreach (AudioSource audioSource in audioSources)
        {
            audioSource.mute = isMuted;
        }
    }
}
