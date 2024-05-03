using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Stats : MonoBehaviour
{
    public GameObject StatsCanvas;
    public GameObject Canvas;
    public GameObject SettingsCanvas;
    private bool isToggled = false;
    [SerializeField]
    Text BestTime;
    public float level;

    void Start()
    {//checks if the player has a time set for each level, and sets the finish screens "Best Time" to this number
        if (PlayerPrefs.GetFloat("BestTimeLevel" + level) > 1)
        {
            Debug.Log(PlayerPrefs.GetFloat("BestTimeLevel" + level));
            BestTime.text = "Best: " + PlayerPrefs.GetFloat("BestTimeLevel" + level).ToString("0.00");//sets best time text to current level best time to 2 dp
        }//if not, remove all text
        else
        {
            BestTime.text = " ";
        }
    }

    public void resetPrefs()
    {//resets all player prefs (stats)
        PlayerPrefs.DeleteAll();
        StatsCanvas.SetActive(false);
        isToggled = !isToggled;
    }

    public void ToggleResetStats()
    {//shows the reset stats canvas
        StatsCanvas.SetActive(true);
        SettingsCanvas.SetActive(false);
        Canvas.SetActive(false);
    }

    public void TurnOffReset()
    {//closes the reset stats canvas, and opens the menu
        StatsCanvas.SetActive(false);
        SettingsCanvas.SetActive(false);
        Canvas.SetActive(true);
    }

    public void TurnOnReset()
    {
        StatsCanvas.SetActive(true);
    }
}
