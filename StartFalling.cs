using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFalling : MonoBehaviour
{
    public Rigidbody2D fallingObjectRb;
    public Rigidbody2D playerRb;
    public float thresholdY = 10f;

    void Update()
    {
        if (playerRb.position.y >= thresholdY)
        {
            fallingObjectRb.gravityScale = 1;
        }
        
    }
}
