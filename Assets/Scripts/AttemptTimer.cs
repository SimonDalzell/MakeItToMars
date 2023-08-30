using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AttemptTimer : MonoBehaviour
{
    public float fadeDuration = 3f; // The time in seconds it takes to fade out
    private Text uiText;

    private void Start()
    {
        // Get the reference to the Text component
        uiText = GetComponent<Text>();

        // Start the coroutine to make the text fade away after a delay
        StartCoroutine(FadeAwayAfterDelay());
    }

    private IEnumerator FadeAwayAfterDelay()
    {
        // Wait for the specified delay time
        yield return new WaitForSeconds(fadeDuration);

        // Get the original color of the text
        Color originalColor = uiText.color;

        // Calculate the alpha change per second for the fade effect
        float alphaChangePerSecond = originalColor.a / fadeDuration;

        // Gradually fade the text away
        while (uiText.color.a > 0)
        {
            // Reduce the alpha value based on the elapsed time and alpha change per second
            float newAlpha = uiText.color.a - alphaChangePerSecond * Time.deltaTime;

            // Set the new alpha value while preserving the original color
            uiText.color = new Color(originalColor.r, originalColor.g, originalColor.b, newAlpha);

            // Wait for the next frame
            yield return null;
        }

        // Ensure the text becomes completely transparent
        uiText.color = new Color(originalColor.r, originalColor.g, originalColor.b, 0f);
    }
}