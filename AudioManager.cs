using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private bool isMuted;

    private static AudioManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance != this)
            {
                DontDestroyOnLoad(gameObject);
            }
        }

        isMuted = PlayerPrefs.GetInt("IsMuted", 0) == 1;
        AudioListener.volume = isMuted ? 0 : 1;
    }

    public void ToggleMute()
    {
        if (isMuted)
        {
            isMuted = false;
            AudioListener.volume = 1;
            PlayerPrefs.SetInt("IsMuted", 0);
        }
        else
        {
            isMuted = true;
            AudioListener.volume = 0;
            PlayerPrefs.SetInt("IsMuted", 1);
        }
        PlayerPrefs.Save();

        Debug.Log("Audio is " + (isMuted ? "muted" : "unmuted"));
    }

    void OnApplicationQuit()
    {
        PlayerPrefs.Save();
    }
}
