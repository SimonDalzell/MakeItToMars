using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movement2 : MonoBehaviour
{
    [SerializeField]
    Text AttemptNumber;
    [SerializeField]
    Text Score;
    [SerializeField]
    Text Highscore;
    [SerializeField]
    Text Username;

    [SerializeField]     
    private TimeKeeper timeKeeper;


   // public Text myScore;
    public float jumpForce = 5f;
    public float moveSpeed = 2f;
    public float maxHeight = 0f;
    public float finishHeight = 100f;
    public GameObject finishMenu;
    public GameObject pauseMenu;
    private bool isFinished;
    private Rigidbody2D rb;
    private CheckPlayerCollision refer;
    

    private void Start()
    {
        //Username.text = "Username: " + PlayerPrefs.GetString("SavedUsername");
                Time.timeScale = 1f; 
                refer = FindObjectOfType<CheckPlayerCollision>();

        rb = GetComponent<Rigidbody2D>();
        if (PlayerPrefs.HasKey("Highscore")) 
        {
             maxHeight = PlayerPrefs.GetFloat("Highscore");
        }
    }

    private void Update()
    {
        //Debug.Log(PlayerPrefs.GetFloat("FinishTime2"));
        Debug.Log(PlayerPrefs.GetInt("CurrentLevel"));

        float currentHeight = transform.position.y;

        if (currentHeight > maxHeight)
        {
            maxHeight = currentHeight;
            PlayerPrefs.SetFloat("Highscore", maxHeight); 
        }
        if (currentHeight > finishHeight)
        {
            ToggleFinished();
            timeKeeper.StopTimer();
            PlayerPrefs.SetFloat("FinishTime2", timeKeeper.CurrentTime);
        }
       // Debug.Log("u"  + PlayerPrefs.GetString("SavedUsername"));

        Score.text = "Progress: " + currentHeight.ToString("0") + "%";
        //AttemptNumber.text = "Attempts: " + PlayerPrefs.GetInt("attempts");
        AttemptNumber.text = "Attempt #" + PlayerPrefs.GetInt("Attempts").ToString("0");

        //Highscore.text = "Highscore: " + PlayerPrefs.GetFloat("Highscore").ToString("0.00");
         //   Debug.Log(PlayerPrefs.GetInt("Attempts"));

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Jump(-1f);
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Jump(1f); 
            transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
    }

    private void Jump(float direction)
    {
        rb.velocity = new Vector2(direction * moveSpeed, jumpForce);
    }   
     public void HidePauseMenu()
    {
        pauseMenu.SetActive(false);
       // Time.timeScale = 1f; // Resume the game
    }

    public void ToggleFinished()
    {
        Time.timeScale = 0f;
                    HidePauseMenu();

        finishMenu.SetActive(true);
            PlayerPrefs.SetInt("Attempts", 0);
                }
        
}
     

