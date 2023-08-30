using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerTransparency : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public float newAlpha = 0.5f; // Set the new alpha value between 0 (fully transparent) and 1 (fully opaque)

    // Call this method to lower the transparency of the image
    public void LowerImageTransparency()
    {
        if (spriteRenderer != null)
        {
            Color color = spriteRenderer.color;
            color.a = newAlpha;
            spriteRenderer.color = color;
        }
    }
}
