using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CollectCoin : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    public float touchDistanceThreshold = 0.1f;
    public int level;
    public AudioClip coinSound;
    private AudioSource audioSource;
    public bool hasTouchedCoin = false;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (hasTouchedCoin == true)
        {
            return;
        }

        int collectedCoinCount = PlayerPrefs.GetInt("CollectedCoinCount" + level, 0);
        //Debug.Log(collectedCoinCount);
        //Check if the objects are touching based on distance
        if (AreObjectsTouching(object1.transform, object2.transform, touchDistanceThreshold))
        {
            //Remove the coin from the scene when they touch
            object1.SetActive(false);
            collectedCoinCount++;
            PlayerPrefs.SetInt("CollectedCoinCount" + level, collectedCoinCount);
            audioSource.PlayOneShot(coinSound);

            hasTouchedCoin = true;
        }
    }

    bool AreObjectsTouching(Transform obj1, Transform obj2, float threshold)
    {
        //Calculate the distance between the object centers
        float distance = Vector3.Distance(obj1.position, obj2.position);

        //Check if the distance is less than the threshold
        return distance <= threshold;
    }
}


