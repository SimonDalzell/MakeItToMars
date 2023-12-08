using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform target;      // The player's transform
    public float smoothSpeed = 0.125f; // The smoothness of camera movement
    public Vector3 offset;        // The offset from the player's position
    public float minHeight = 5.5f;  // The minimum height the camera cannot go below

    void FixedUpdate()
    {
        // Calculate the desired position for the camera to follow the player
        Vector3 desiredPosition = new Vector3(transform.position.x, target.position.y, transform.position.z) + offset;

        // Check if the desired position goes below the minimum height
        if (desiredPosition.y < minHeight)
        {
            // Set the desired position to the minimum height
            desiredPosition.y = minHeight;
        }

        // Interpolate the camera's current position to the desired position smoothly
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Update the camera's position to the smoothed position
        transform.position = smoothedPosition;
    }
}
