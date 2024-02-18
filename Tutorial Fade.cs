using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TutorialFade : MonoBehaviour
{
    public float alphaDecreaseRate = 0.1f; 
    private SpriteRenderer spriteRenderer;
    bool StartToLower = false;
    int AttemptNumber;
    public int NecessaryAttempts = 5;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        AttemptNumber =  PlayerPrefs.GetInt("Attempts");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || (Input.touchCount > 0)){
            StartToLower = true;
        }
        if (StartToLower == true){
            LowerTransparency();
        }
        if (AttemptNumber > NecessaryAttempts){
            RemoveTutorial();
        }
    }

    public void LowerTransparency(){
        Color currentColor = spriteRenderer.color;
        currentColor.a -= alphaDecreaseRate * Time.deltaTime;
        spriteRenderer.color = currentColor;


    }

    public void RemoveTutorial(){
        Color currentColor = spriteRenderer.color;
        currentColor.a = 0;
        spriteRenderer.color = currentColor;


    }
}

