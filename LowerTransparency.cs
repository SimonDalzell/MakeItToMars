using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerTransparency : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public float newAlpha = 0.5f;

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
