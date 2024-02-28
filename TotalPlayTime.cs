using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TotalPlayTime : MonoBehaviour
{
    private float totalTimePlayed = 0f;
    private string totalTimeKey = "TotalTimePlayed";
    [SerializeField] Text PlayTimeText;
    [SerializeField] Text BestHeight;

    string formattedTime;

    void Start()
    {
        LoadTotalTime();

        int hours = Mathf.FloorToInt(totalTimePlayed / 3600);
        int minutes = Mathf.FloorToInt((totalTimePlayed % 3600) / 60);
        int seconds = Mathf.FloorToInt(totalTimePlayed % 60);
        formattedTime = string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);
        PlayTimeText.text = "Play Time: \n" + formattedTime;
        BestHeight.text = "FreePlay Best Height: \n" + PlayerPrefs.GetFloat("BestHeight", 0f).ToString("0.00");

    }

    void Update()
    {
        LoadTotalTime();
        totalTimePlayed += Time.deltaTime;
        SaveTotalTime();
    }

    void OnApplicationQuit()
    {
        SaveTotalTime();
    }

    void SaveTotalTime()
    {
        PlayerPrefs.SetFloat(totalTimeKey, totalTimePlayed);
        PlayerPrefs.Save();
    }

    void LoadTotalTime()
    {
        if (PlayerPrefs.HasKey(totalTimeKey))
        {
            totalTimePlayed = PlayerPrefs.GetFloat(totalTimeKey);
        }
    }
}
