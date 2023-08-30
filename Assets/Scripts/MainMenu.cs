using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MainMenu : MonoBehaviour
{
        
    public void Start()
    {
        //Time.timeScale = 1f; 
    }
    public void PlayButton()
    {
        SceneManager.LoadScene("LevelOne");
    }
    public void LevelsButton()
    {
        SceneManager.LoadScene("Levels");
    }
    public void LoginButton()
    {
        SceneManager.LoadScene("Login");
    }
    public void HomeButton()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }
        public void StatsButton()
    {
        SceneManager.LoadScene("Stats");
    }
}
