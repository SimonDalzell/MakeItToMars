using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AttemptTimer : MonoBehaviour
{
    public float fadeDuration = 3f; 
    private Text uiText;

    private void Start()
    {
        uiText = GetComponent<Text>();

        StartCoroutine(FadeAwayAfterDelay());
    }

    private IEnumerator FadeAwayAfterDelay()
    {
        yield return new WaitForSeconds(fadeDuration);

        Color originalColor = uiText.color;

        float alphaChangePerSecond = originalColor.a / fadeDuration;

        while (uiText.color.a > 0)
        {
            float newAlpha = uiText.color.a - alphaChangePerSecond * Time.deltaTime;

            uiText.color = new Color(originalColor.r, originalColor.g, originalColor.b, newAlpha);

            yield return null;
        }


        uiText.color = new Color(originalColor.r, originalColor.g, originalColor.b, 0f);
    }
}