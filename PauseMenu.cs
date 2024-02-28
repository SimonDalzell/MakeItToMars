using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject blurScreen;
    public GameObject canvas;
    private bool isPaused;
    private bool isBlurred;

    [SerializeField]
    Text Countdowntext;

    private void OnDisable()
    {
        Debug.Log("DisabledUnpause");
        if (isPaused)
        {
            Debug.Log("DisabledPause");
            //Time.timeScale = 1f;
            isPaused = false;
        }
    }

    public void TogglePause()
    {
        isPaused = !isPaused;
        isBlurred = !isBlurred;

        if (isPaused)
        {
            Time.timeScale = 0f;
            pauseMenu.SetActive(true);
            blurScreen.SetActive(true);
        }
        else
        {
            Time.timeScale = 1f;
            pauseMenu.SetActive(false);
            blurScreen.SetActive(false);
        }
    }

    public void StartCountdown()
    {

        StartCoroutine(CountdownCoroutine());


    }

    IEnumerator CountdownCoroutine()
    {
        Time.timeScale = 0f;

        Countdowntext.text = "3";
        yield return new WaitForSecondsRealtime(1f);

        Countdowntext.text = "2";
        yield return new WaitForSecondsRealtime(1f); 

        Countdowntext.text = "1";
        yield return new WaitForSecondsRealtime(1f);

        Countdowntext.text = "";

        Time.timeScale = 1f;

        yield return null;
    }

    public void Pause()
    {
        isPaused = !isPaused;
        isBlurred = !isBlurred;

        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
        blurScreen.SetActive(true);
        canvas.SetActive(false);
    }
    public void UnPause()
    {
        isPaused = !isPaused;
        isBlurred = !isBlurred;

        //Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        blurScreen.SetActive(false);
        canvas.SetActive(true);

    }
}