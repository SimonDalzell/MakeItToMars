using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject blurScreen;
    public GameObject canvas;
    private bool isPaused;
    private bool isBlurred;


    private void OnDisable()
    {
        if (isPaused)
        {
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

        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        blurScreen.SetActive(false);
        canvas.SetActive(true);

    }
}