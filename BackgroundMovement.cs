using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    public float speed = 1.0f;      // Speed of the background movement
    public float distance = 2.0f;   // Distance the background will move

    private float originalX;       // Original X position of the background
    private float targetX;         // Target X position for the background to move towards

    void Start()
    {
        originalX = transform.position.x;
        targetX = originalX + distance;
    }

    void Update()
    {
        // Calculate the new position based on the current time and speed
        float newX = Mathf.PingPong(Time.time * speed, distance) + originalX;

        // Update the background position
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
}
