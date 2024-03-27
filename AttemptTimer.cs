using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AttemptTimer : MonoBehaviour
{
    public float fadeDuration = 3f; 
    private Text uiText;

    private void Start()
    {
        //Get text component and start to fade for attempt number
        uiText = GetComponent<Text>();
        StartCoroutine(FadeAwayAfterDelay());
    }

    private IEnumerator FadeAwayAfterDelay()
    {
        yield return new WaitForSeconds(fadeDuration);
        Color originalColor = uiText.color;

        float alphaChangePerSecond = originalColor.a / fadeDuration;

        //Adjust alpha component of text
        while (uiText.color.a > 0)
        {
            float newAlpha = uiText.color.a - alphaChangePerSecond * Time.deltaTime;

            uiText.color = new Color(originalColor.r, originalColor.g, originalColor.b, newAlpha);

            yield return null;
        }


        uiText.color = new Color(originalColor.r, originalColor.g, originalColor.b, 0f);
    }
}