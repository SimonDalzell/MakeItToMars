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


    }
    public void LevelThree()
    {
        SceneManager.LoadScene("Level3");
                PlayerPrefs.SetInt("CurrentLevel", 3);
                    PlayerPrefs.SetInt("Attempts", 0);


    }
    public void LevelFour()
    {
        SceneManager.LoadScene("Level4");
        PlayerPrefs.SetInt("CurrentLevel", 4);
        PlayerPrefs.SetInt("Attempts", 0);
    }
    public void LevelFive()
    {
        SceneManager.LoadScene("Level5");
        PlayerPrefs.SetInt("CurrentLevel", 5);
        PlayerPrefs.SetInt("Attempts", 0);
    }
    public void LevelSix()
    {
        SceneManager.LoadScene("Level6");
        PlayerPrefs.SetInt("CurrentLevel", 6);
        PlayerPrefs.SetInt("Attempts", 0);
    }
    public void LevelSeven()
    {
        SceneManager.LoadScene("Level7");
        PlayerPrefs.SetInt("CurrentLevel", 7);
        PlayerPrefs.SetInt("Attempts", 0);
    }
    public void LevelEight()
    {
        SceneManager.LoadScene("Level8");
        PlayerPrefs.SetInt("CurrentLevel", 8);
        PlayerPrefs.SetInt("Attempts", 0);
    }
    public void LevelNine()
    {
        SceneManager.LoadScene("Level9");
        PlayerPrefs.SetInt("CurrentLevel", 9);
        PlayerPrefs.SetInt("Attempts", 0);
    }
    public void LevelTen()
    {
        SceneManager.LoadScene("Level10");
        PlayerPrefs.SetInt("CurrentLevel", 10);
        PlayerPrefs.SetInt("Attempts", 0);
    }
    public void LevelEleven()
    {
        SceneManager.LoadScene("Level11");
        PlayerPrefs.SetInt("CurrentLevel",11);
        PlayerPrefs.SetInt("Attempts", 0);
    }
    public void LevelTwelve()
    {
        SceneManager.LoadScene("Level12");
        PlayerPrefs.SetInt("CurrentLevel", 12);
        PlayerPrefs.SetInt("Attempts", 0);
    }
    public void LevelThirteen()
    {
        SceneManager.LoadScene("Level13");
        PlayerPrefs.SetInt("CurrentLevel", 13);
        PlayerPrefs.SetInt("Attempts", 0);
    }
    public void LevelFourteen()
    {
        SceneManager.LoadScene("Level14");
        PlayerPrefs.SetInt("CurrentLevel", 14);
        PlayerPrefs.SetInt("Attempts", 0);
    }
    public void MainMenu()
    {
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
        if (currentLevel > 14)
        {
            currentLevel=1;
            //Debug.Log(currentLevel);
        }
        SceneManager.LoadScene("Level" + currentLevel); 

    }
    public void endScene()
    {
        SceneManager.LoadScene("Finish");
    }
    public void Update()
    {
    }
    public void Freeplay()
    {
        SceneManager.LoadScene("LevelFreeplay");
        PlayerPrefs.SetInt("Attempts", 0);
    }



}
