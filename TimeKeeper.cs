using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeKeeper : MonoBehaviour
{
    [SerializeField] private Text timerText;

    private float startTime;
    private float currentTime;
    private bool isTimerRunning;

    public float FinishHeight { get; private set; }
    public float CurrentTime => currentTime;

    private void Start()
    {
        // Start the timer when the scene starts
        StartTimer();
    }

    private void Update()
    {
        // Update the timer if it is running
        if (isTimerRunning)
        {
            currentTime = Time.time - startTime;
           // Debug.Log("Timer: " + currentTime.ToString("F2"));
        }

        timerText.text = "Time: " + currentTime.ToString("0.00");
    }

    private void StartTimer()
    {
        // Set the start time to the current time
        startTime = Time.time;
        isTimerRunning = true;
    }

    public void StopTimer()
    {
        isTimerRunning = false;
    }
}