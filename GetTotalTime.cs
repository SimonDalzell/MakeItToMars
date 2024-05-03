using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GetTotalTime : MonoBehaviour
{

    [SerializeField]
    Text TotalTime;
    [SerializeField]
    Text finishedTime;

    void Start()
    {
       GetFinished();
    }

    void Update()
    {
        
    }

    public void GetFinished()
    {//gets all best times for each level
        bool finished = false;
        float bt1 = PlayerPrefs.GetFloat("BestTimeLevel1");
        float bt2 = PlayerPrefs.GetFloat("BestTimeLevel2");
        float bt3 = PlayerPrefs.GetFloat("BestTimeLevel3");
        float bt4 = PlayerPrefs.GetFloat("BestTimeLevel4");
        float bt5 = PlayerPrefs.GetFloat("BestTimeLevel5");
        float bt6 = PlayerPrefs.GetFloat("BestTimeLevel6");
        float bt7 = PlayerPrefs.GetFloat("BestTimeLevel7");
        float bt8 = PlayerPrefs.GetFloat("BestTimeLevel8");
        float bt9 = PlayerPrefs.GetFloat("BestTimeLevel9");
        float bt10 = PlayerPrefs.GetFloat("BestTimeLevel10");
        float bt11 = PlayerPrefs.GetFloat("BestTimeLevel11");
        float bt12 = PlayerPrefs.GetFloat("BestTimeLevel12");
        float bt13 = PlayerPrefs.GetFloat("BestTimeLevel13");
        float bt14 = PlayerPrefs.GetFloat("BestTimeLevel14");
        

        float[] totalTime = { bt1, bt2, bt3, bt4, bt5, bt6, bt7, bt8, bt9, bt10, bt11, bt12, bt13, bt14 };
        
        foreach (float i in totalTime)//ensures all levels have been completed
        {
            if (i <= 0)
            {
                finished = false;
            }
            else if (i > 0)
            { 
                finished = true;
            }
        }

        if (finished == true)
        {
            finishedTime.text = "You made it to mars!";
        }
        else
        {
            finishedTime.text = "You have not yet \n made it to mars..";
        }
    }

    public void GetAllTimes()
    {//calculates the total time spent in game
        float allTime = 0;
        for (int i = 0; i < 14; i++)
        {
            allTime = allTime + PlayerPrefs.GetFloat("BestTimeLevel" + i);
        }
        TotalTime.text = "Time Taken: " + allTime.ToString("0.00");

    }
}
