using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CheckEnemyCollision : MonoBehaviour
{
    private Rigidbody2D rb;
    //For falling walls
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //If enemy touches walls or safewalls, remove it from the scene
        if (collision.gameObject.CompareTag("Walls") || collision.gameObject.CompareTag("SafeWall"))
        {
            gameObject.SetActive(false);
        }
    }
}
