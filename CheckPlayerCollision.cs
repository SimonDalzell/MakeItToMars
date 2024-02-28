using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CheckPlayerCollision : MonoBehaviour
{
    public int attempts = 1;
    private FreePlayDeath freePlayDeath;
    public void Start()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Walls"))
        {
            attempts = PlayerPrefs.GetInt("Attempts", 1) + 1;
            PlayerPrefs.SetInt("Attempts", attempts);
            PlayerPrefs.Save();
            Handheld.Vibrate();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
