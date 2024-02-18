using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGeneration : MonoBehaviour
{
    public GameObject leftSpikePrefab;
    public GameObject rightSpikePrefab;
    public GameObject smallPlatform;
    public GameObject platformDownRotated;
    public GameObject movingPlats;


    public float minY = 0f;
    public float maxY = 4000f;

    void Start()
    {
        GenerateSpikes();
        GeneratePlatforms();
        GenerateSmallPlatforms();
        GenerateMovingPlatforms();
    }

    void GenerateSpikes()
    {
        float interval = 5f;

        for (float y = minY; y <= maxY; y += interval)
        {
            float randomLeftY = y;
            float randomRightY = 2.5f + y;

            Vector3 spawnLeftPosition = new Vector3(-2.88f, randomLeftY, 0f);
            Vector3 spawnRightPosition = new Vector3(2.88f, randomRightY, 0f);

            Instantiate(leftSpikePrefab, spawnLeftPosition, Quaternion.Euler(0f, 0f, 90f));
            Instantiate(rightSpikePrefab, spawnRightPosition, Quaternion.Euler(0f, 0f, 90f));
        }
    }

    void GeneratePlatforms()
    {
        float interval = 12f;

        for (float y = 5; y <= maxY; y += interval)
        {
            float randomLeftY = y;

            float randomX = Random.Range(-1, 1);
            float randomRotation = Random.Range(-90, 90);

            Vector3 spawnPosition = new Vector3(randomX, randomLeftY, 0f);
            Instantiate(platformDownRotated, spawnPosition, Quaternion.Euler(0f, 0f, randomRotation));
        }
    }

    void GenerateSmallPlatforms()
    {
        float interval = 12f;

        for (float y = 10; y <= maxY; y += interval)
        {
            float randomLeftY = y;

            float randomX = Random.Range(-3, 3);

            Vector3 spawnPosition = new Vector3(randomX, randomLeftY, 0f);

            Instantiate(smallPlatform, spawnPosition, Quaternion.Euler(0f, 0f, 0));
        }
    }

    void GenerateMovingPlatforms()
    {
        float interval = 24f;

        for (float y = 12.5f; y <= maxY; y += interval)
        {
            float randomLeftY = y;

            float randomX = Random.Range(-3, 3);
            float randomRotation = Random.Range(-45, 45);

            Vector3 spawnPosition = new Vector3(randomX, randomLeftY, 0f);

            Instantiate(movingPlats, spawnPosition, Quaternion.Euler(0f, 0f, randomRotation));
        }
    }

}