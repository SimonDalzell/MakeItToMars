using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    [SerializeField]
    Text BestTime1;
    [SerializeField]
    Text BestTime2;
    // Start is called before the first frame update
    void Start()
    {
        BestTime1.text = "Best Time Level One: " + PlayerPrefs.GetFloat("FinishTime1").ToString("0.00");
        BestTime2.text = "Best Time Level Two: " + PlayerPrefs.GetFloat("FinishTime2").ToString("0.00");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(PlayerPrefs.GetFloat("FinishTime1"));



    }
}
