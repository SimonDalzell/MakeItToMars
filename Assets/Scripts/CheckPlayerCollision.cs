using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CheckPlayerCollision : MonoBehaviour
{

    //[SerializeField]
    //Text AttemptNumber;
    public int attempts;
    public void Start()
    {
        //AttemptNumber.text = "Attempts: " + PlayerPrefs.GetInt("Attempts").ToString("0.00");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Walls"))
        {
            attempts = PlayerPrefs.GetInt("Attempts", 1) + 1;
            PlayerPrefs.SetInt("Attempts", attempts);
            PlayerPrefs.Save();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
           // Debug.Log(PlayerPrefs.GetInt("Attempts"));
        }
    }
}
