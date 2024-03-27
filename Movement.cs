using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    [SerializeField]
    Text AttemptNumber;
    [SerializeField]
    Text Score;


    public TimeKeeper timeKeeper;
    public GameObject blurScreen;

    public AudioClip jumpSound;
    private AudioSource audioSource;

    public float jumpForce = 5f;
    public float moveSpeed = 2f;
    public float maxHeight = 0f;
    public float finishHeight = 100f;

    public GameObject finishMenu;
    public GameObject canvas;
    public GameObject pauseMenu;
    private bool isFinished;
    private Rigidbody2D rb;
    private CheckPlayerCollision refer;
    private FreePlayDeath freePlayDeath;


    private void Start()
    {
        Time.timeScale = 1f;
        refer = FindObjectOfType<CheckPlayerCollision>();
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = jumpSound;
        freePlayDeath = GetComponent<FreePlayDeath>();

    }

    private void Update()
    {
        int CurrentLevel = PlayerPrefs.GetInt("CurrentLevel");
        float currentHeight = transform.position.y;
        if (currentHeight > finishHeight)
        {
            timeKeeper.StopTimer();

            string finishTimeKey = "FinishTime" + CurrentLevel.ToString();
            string bestTimeKey = "BestTime" + SceneManager.GetActiveScene().name;// = BestTime1

            PlayerPrefs.SetFloat(finishTimeKey, timeKeeper.CurrentTime);

            if (!PlayerPrefs.HasKey(bestTimeKey))
            {
                PlayerPrefs.SetFloat(bestTimeKey, timeKeeper.CurrentTime);
            }
            else
            {
                if (PlayerPrefs.GetFloat(finishTimeKey) < PlayerPrefs.GetFloat(bestTimeKey))
                {
                    PlayerPrefs.SetFloat(bestTimeKey, PlayerPrefs.GetFloat(finishTimeKey));
                }
            }
            
            ToggleFinished();
        }
        Score.text = "Progress: " + currentHeight.ToString("0") + "%";
        AttemptNumber.text = "Attempt #" + PlayerPrefs.GetInt("Attempts").ToString("0");
        bool canJumpLeft = true; 
        bool canJumpRight = true;
        if (Input.touchCount > 0)
        {
            for (int i = 0; i < Input.touchCount; ++i)
            {
                Touch touch = Input.GetTouch(i);

                if (touch.phase == TouchPhase.Began)
                {
                    if (touch.position.x < Screen.width / 2 && canJumpLeft && touch.position.y < (Screen.height / 100) * 45)
                    {
                        Jump(-1f);
                        transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
                        canJumpLeft = false;
                    }
                    else if (touch.position.x > Screen.width / 2 && canJumpRight && touch.position.y < (Screen.height / 100 ) * 45)
                    {
                        Jump(1f);
                        transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
                        canJumpRight = false;
                    }
                }

                if (touch.phase == TouchPhase.Ended)
                {
                    if (touch.position.x < Screen.width / 2)
                    {
                        canJumpLeft = true; 
                    }
                    else if (touch.position.x > Screen.width / 2)
                    {
                        canJumpRight = true;
                    }
                }
            }
        }
            
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Jump(-1f);
                    transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
                    audioSource.PlayOneShot(jumpSound);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    Jump(1f);
                    transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
                    audioSource.PlayOneShot(jumpSound);
        
        }



    }

    private void Jump(float direction)
    {
        rb.velocity = new Vector2(direction * moveSpeed, jumpForce);
    }

    public void HidePauseMenu()
    {
        pauseMenu.SetActive(false);
    }

    public void HideCanvas()
    {
        canvas.SetActive(false);
    }

    public void ToggleFinished()
    {
        Time.timeScale = 0f;
        HidePauseMenu();
        finishMenu.SetActive(true);
        blurScreen.SetActive(true);
        PlayerPrefs.SetInt("Attempts", 1);
    }



    private void OnApplicationPause(bool pause)
    {
        if (freePlayDeath.IsDead() == false)
        {
            Debug.Log("Pause");
            Time.timeScale = 0f;
            pauseMenu.SetActive(true);
        }      
    }
}