using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetPlayerHeight : MonoBehaviour
{
    [SerializeField] Text heightText;

    private Rigidbody2D rb;
    private float bestHeight;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bestHeight = PlayerPrefs.GetFloat("BestHeight", 0f);
    }

    void Update()
    {
        float currentHeight = transform.position.y;

        if (currentHeight > bestHeight)
        {
            bestHeight = currentHeight;
            PlayerPrefs.SetFloat("BestHeight", bestHeight);
        }

        heightText.text = "Height: " + currentHeight.ToString("0.00") + "\nBest Height: " + bestHeight.ToString("0.00");
    }
}
