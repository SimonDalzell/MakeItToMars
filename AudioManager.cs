using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private bool isMuted;
    private static AudioManager instance;

    //Mutes all game sound
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
        //Get users mute setting
        isMuted = PlayerPrefs.GetInt("IsMuted", 0) == 1;
        AudioListener.volume = isMuted ? 0 : 1;
    }

    public void ToggleMute()
    {
        //If user has muted sound, unmute and vise versa
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
        //save setting
        PlayerPrefs.Save();
    }
}
