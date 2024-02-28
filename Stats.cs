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
    private bool isToggled = false;


    [SerializeField]
    Text BestTime;
    public float level;

    void Start()
    {
    }

    void Update()
    {
        BestTime.text = "Best: " + PlayerPrefs.GetFloat("BestTimeLevel" + level).ToString("0.00");//sets best time text to current level best time to 2 dp
    }


    public void CheckStats()//not used anymore
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
        isToggled = !isToggled;
    }
    public void ToggleResetStats()
    {
        if (isToggled == true)
        {
            StatsCanvas.SetActive(false);
        }
        else
        {
            StatsCanvas.SetActive(true);
        }
        isToggled = !isToggled;
    }

    public void TurnOffReset()
    {
        StatsCanvas.SetActive(false);
    }

    public void TurnOnReset()
    {
        StatsCanvas.SetActive(true);
    }
}
