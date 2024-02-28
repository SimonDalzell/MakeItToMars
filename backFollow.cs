using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backFollow : MonoBehaviour

   {
    public Transform playerTransform;
    public float parallaxFactor = 0.5f;

    private Vector3 initialPosition;

    private void Start()
    {
        initialPosition = transform.position;
    }

    private void Update()
    {
        if (playerTransform != null)
        {
            float parallaxX = (playerTransform.position.x - initialPosition.x) * parallaxFactor;
            float parallaxY = (playerTransform.position.y - initialPosition.y) * parallaxFactor;

            Vector3 targetPosition = new Vector3(initialPosition.x + parallaxX, initialPosition.y + parallaxY, transform.position.z);
            transform.position = targetPosition;
        }
    }
}

