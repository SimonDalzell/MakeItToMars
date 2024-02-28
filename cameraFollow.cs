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
        Vector3 desiredPosition = new Vector3(transform.position.x, target.position.y, transform.position.z) + offset;

        if (desiredPosition.y < minHeight)
        {
            desiredPosition.y = minHeight;
        }

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;
    }
}
