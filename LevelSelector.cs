using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelSelector : MonoBehaviour
{
    private void Start()
    {
        if (!PlayerPrefs.HasKey("CurrentLevel"))
        {
            PlayerPrefs.SetInt("CurrentLevel", 1);
        }
    }
    public void LevelOne()
    {
        SceneManager.LoadScene("Level1");
                PlayerPrefs.SetInt("CurrentLevel", 1); 
                    PlayerPrefs.SetInt("Attempts", 0);


    }
    public void LevelTwo()
    {
        SceneManager.LoadScene("Level2");
                PlayerPrefs.SetInt("CurrentLevel", 2);
                    PlayerPrefs.SetInt("Attempts", 0);


        //Time.timeScale = 1f; 
    }
    public void LevelThree()
    {
        SceneManager.LoadScene("Level3");
                PlayerPrefs.SetInt("CurrentLevel", 3);
                    PlayerPrefs.SetInt("Attempts", 0);


        //Time.timeScale = 1f; 
    }
    public void LevelFour()
    {
        SceneManager.LoadScene("Level4");
        PlayerPrefs.SetInt("CurrentLevel", 4);
        PlayerPrefs.SetInt("Attempts", 0);


        //Time.timeScale = 1f; 
    }
    public void LevelFive()
    {
        SceneManager.LoadScene("Level5");
        PlayerPrefs.SetInt("CurrentLevel", 5);
        PlayerPrefs.SetInt("Attempts", 0);


        //Time.timeScale = 1f; 
    }
    public void MainMenu()
    {
        //Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
    public void NextLevel()
    {
        int currentLevel = PlayerPrefs.GetInt("CurrentLevel", 1); 
        currentLevel++; 
        PlayerPrefs.SetInt("CurrentLevel", currentLevel); 
            PlayerPrefs.SetInt("Attempts", 0);

        SceneManager.LoadScene("Level" + currentLevel); 
    }
    public void RunCurrentLevel()
    {        
        int currentLevel = PlayerPrefs.GetInt("CurrentLevel", 1); 
        if (currentLevel > 4)
        {
            currentLevel=1;
            Debug.Log(currentLevel);
        }
        SceneManager.LoadScene("Level" + currentLevel); 

    }
    public void Update()
    {
        //PlayerPrefs.SetInt("CurrentLevel", 1); // Save the new current level       
    }


}
