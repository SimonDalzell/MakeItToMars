using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GetCoinCount : MonoBehaviour
{
    public float level;
    public Image emptyCoin;
    public Sprite fullCoin;


    void Start()
    {
        int coinsCollected = PlayerPrefs.GetInt("CollectedCoinCount" + level, 0);
        if (coinsCollected > 0)
        {
            ChangeImage(emptyCoin, fullCoin);
        }
        Debug.Log(coinsCollected);

    }

    void Update()
    {
    }

    void ChangeImage(Image targetImage, Sprite newSprite)
    {
        targetImage.sprite = newSprite;
    }

    void ImageToImage(Image currentImage, Image newImage)
    {
        currentImage.sprite = newImage.sprite;
    }
}
