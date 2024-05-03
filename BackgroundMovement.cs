using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    public float speed = 1.0f;      
    public float distance = 2.0f;
    private float originalX;     
    private float targetX;

    void Start()
    {
        originalX = transform.position.x;
        targetX = originalX + distance;
    }

    void Update()
    {
        //Move background a set distance back and forth
        float newX = Mathf.PingPong(Time.time * speed, distance) + originalX;

        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
}
