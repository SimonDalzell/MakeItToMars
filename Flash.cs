using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour
{
    private SpriteRenderer playerSprite;

    void Start()
    {
        playerSprite = GetComponent<SpriteRenderer>();

        //Start the flashing coroutine
        StartCoroutine(ContinuousFlash());
    }

    IEnumerator ContinuousFlash()
    {
        while (true)
        {
            //Call the FlashAlpha function for duration seconds
            float duration = 2f; 
            float flashDuration = duration / 2f;

            yield return FlashAlpha(1f, 0.5f, flashDuration);

            yield return FlashAlpha(0.5f, 1f, flashDuration);
        }
    }

    IEnumerator FlashAlpha(float startAlpha, float endAlpha, float duration)
    {
        float startTime = Time.time;

        while (Time.time - startTime < duration)
        {
            float t = (Time.time - startTime) / duration;

            //Interpolate between start alpha and end
            float alpha = Mathf.Lerp(startAlpha, endAlpha, t);

            SetSpriteAlpha(alpha);

            yield return null;
        }

        SetSpriteAlpha(endAlpha);
    }

    void SetSpriteAlpha(float alpha)
    {
        Color spriteColor = playerSprite.color;
        spriteColor.a = alpha;
        playerSprite.color = spriteColor;
    }
}
