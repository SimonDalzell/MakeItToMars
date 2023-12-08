using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Stats : MonoBehaviour
{
    [SerializeField]
    Text BestTime1;
    [SerializeField]
    Text BestTime2;
    [SerializeField]
    Text BestTime3;
    [SerializeField]
    Text BestTime4;
    [SerializeField]
    Text BestTime5;
    public GameObject StatsCanvas;
    public GameObject BlurScreen;
    //private bool isBlurred = false;
    private bool isToggled = false;

    void Start()
    {
        CheckStats();
    }

    void Update()
    {
       // Debug.Log(PlayerPrefs.GetFloat("BestTimeLevel1"));
    }
    public void CheckStats()
    {
        if (SceneManager.GetActiveScene().name == "Level1")
        {
            if (PlayerPrefs.GetFloat("BestTimeLevel1") < 1)
            {
                BestTime1.text = " ";
            }
            else
            {
                BestTime1.text = "Best Time: " + PlayerPrefs.GetFloat("BestTimeLevel1").ToString("0.00");
            }
        }
        else if (SceneManager.GetActiveScene().name == "Level2")
        {
            if (PlayerPrefs.GetFloat("BestTimeLevel2") < 1)
            {
                BestTime2.text = " ";
            }
            else
            {
                BestTime2.text = "Best Time: " + PlayerPrefs.GetFloat("BestTimeLevel2").ToString("0.00");

            }
        }
        else if (SceneManager.GetActiveScene().name == "Level3")
        {
            if (PlayerPrefs.GetFloat("BestTimeLevel3") < 1)
            {
                BestTime3.text = " ";
            }
            else
            {
                BestTime3.text = "Best Time: " + PlayerPrefs.GetFloat("BestTimeLevel3").ToString("0.00");
            }
        }
        else if (SceneManager.GetActiveScene().name == "Level4")
        {
            if (PlayerPrefs.GetFloat("BestTimeLevel4") < 1)
            {
                BestTime4.text = " ";
            }
            else
            {
                BestTime4.text = "Best Time: " + PlayerPrefs.GetFloat("BestTimeLevel4").ToString("0.00");
            }
        }
        else if (SceneManager.GetActiveScene().name == "Level5")
        {
            if (PlayerPrefs.GetFloat("BestTimeLevel5") < 1)
            {
                BestTime5.text = " ";
            }
            else
            {
                BestTime5.text = "Best Time: " + PlayerPrefs.GetFloat("BestTimeLevel5").ToString("0.00");
            }
        }
    }

    public void resetPrefs()
    {
        PlayerPrefs.DeleteAll();
        StatsCanvas.SetActive(false);
        BlurScreen.SetActive(false);
        isToggled = !isToggled;
    }
    public void ToggleResetStats()
    {
        if (isToggled == true)
        {
            StatsCanvas.SetActive(false);
            BlurScreen.SetActive(false);
        }
        else
        {
            StatsCanvas.SetActive(true);
            BlurScreen.SetActive(true);
        }
        isToggled = !isToggled;
       // isBlurred = !isBlurred;
    }
}
