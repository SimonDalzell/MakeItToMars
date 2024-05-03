using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FreePlayDeath : MonoBehaviour
{

    public GameObject DeathMenu;
    public GameObject blurScreen;
    public GameObject canvas;
    private bool isDead;
    private bool isBlurred;

    private bool isInvincible = false;

    private SpriteRenderer playerSprite;
    private bool isFlashing = false;

    [SerializeField]
    Text Countdowntext;

    void Start()
    {
        playerSprite = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if player is touching a wall and is not invincible, run the dead function
        if (collision.gameObject.CompareTag("Walls") && isInvincible == false)
        {
            Dead();
            Handheld.Vibrate();
            //Debug.Log("Dead" + isInvincible);
        }
    }

    public void StartCountdown()
    {
        StartCoroutine(CountdownCoroutine());
    }

    IEnumerator CountdownCoroutine()
    {
        Time.timeScale = 0f;
        Debug.Log("Time Off");
        Countdowntext.text = "3";
        yield return new WaitForSecondsRealtime(1f);

        Countdowntext.text = "2";
        yield return new WaitForSecondsRealtime(1f);

        Countdowntext.text = "1";
        yield return new WaitForSecondsRealtime(1f);

        Countdowntext.text = "";

        Time.timeScale = 1f;
        Debug.Log("Time On");
        StartFlashing();
        yield return null;
    }

    public bool IsDead()
    {
        return isDead;
    }

    public bool IsInvincible()
    {
        return isInvincible;
    }

    public void Update()
    {
        if (isInvincible && !isWaitAndExecuteRunning)
        {
            StartCoroutine(WaitAndExecute());
        }
    }

    private bool isWaitAndExecuteRunning = false;

    IEnumerator WaitAndExecute()
    {
        //Wait 2 seconds to return to non-invincible mode
        isWaitAndExecuteRunning = true;
        yield return new WaitForSeconds(2f);
        isInvincible = false;
        isWaitAndExecuteRunning = false;
    }


    public void Dead()
    {
        if (!isDead)
        {
            Time.timeScale = 0f;

            isDead = true;
           // isBlurred = true;

            DeathMenu.SetActive(true);
            blurScreen.SetActive(true);
            canvas.SetActive(false);
        }
    }

    public void ReloadScene()
    {
        DeathMenu.SetActive(false);
        blurScreen.SetActive(false);
        canvas.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Continue()
    {
        isInvincible = true;
        DeathMenu.SetActive(false);
        blurScreen.SetActive(false);
        canvas.SetActive(true);
        isDead = false;
        //StartFlashing();
    }


    void StartFlashing()
    {
        if (!isFlashing)
        {
            SetSpriteAlpha(1f);

            StartCoroutine(FlashAlpha());
            Debug.Log("Flashing started");
        }
    }

    IEnumerator FlashAlpha()
    {
        //Flash function to vary the alpha component of the player
        isFlashing = true;

        int flashes = 5;
        float duration = 2.0f; 
        float flashDuration = duration / flashes; 
        float startTime = Time.time;

        while (Time.time - startTime < duration)
        {
            float t = (Time.time - startTime) / flashDuration;

            float alpha = Mathf.PingPong(t, 1f);

            SetSpriteAlpha(alpha);

            yield return null;
        }

        SetSpriteAlpha(1f);

        isFlashing = false;
    }



    void SetSpriteAlpha(float alpha)
    {
        Color spriteColor = playerSprite.color;
        spriteColor.a = alpha;
        playerSprite.color = spriteColor;
    }
}

