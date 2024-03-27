using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform target;      
    public float smoothSpeed = 0.125f;
    public Vector3 offset;        
    public float minHeight = 5.5f; 

    void FixedUpdate()
    {
        //Find where the camera should move
        Vector3 desiredPosition = new Vector3(transform.position.x, target.position.y, transform.position.z) + offset;
        //If the camera should be lower than the ground, set it to the ground
        if (desiredPosition.y < minHeight)
        {
            desiredPosition.y = minHeight;
        }
        
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;
    }
}
