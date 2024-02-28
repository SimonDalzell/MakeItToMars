using UnityEngine;
using UnityEngine.UI;

public class StarPopulator : MonoBehaviour
{
    public Image[] currentImages;
    public Sprite[] newSprites;
    public float level;
    public float OneStar;
    public float TwoStar;
    public float ThreeStar;

    void Start()
    {
        float playerTime = PlayerPrefs.GetFloat("BestTimeLevel" + level);

        if (playerTime == 0f)
        {
            for (int i = 0; i < currentImages.Length; i++)
            {
                Image imageToChange = currentImages[i];
                ImageToImage(imageToChange, imageToChange);
            }
        }
        else
        {
            if (playerTime < OneStar)
            {
                Image imageToChange = currentImages[0];
                ChangeImage(imageToChange, newSprites[0]);
            }
            if (playerTime < TwoStar)
            {
                Image imageToChange = currentImages[1];
                ChangeImage(imageToChange, newSprites[1]);
            }
            if (playerTime >= 0.01f && playerTime <= ThreeStar)
            {
                Image imageToChange = currentImages[2];
                ChangeImage(imageToChange, newSprites[2]);
            }
        }
    }

    void ChangeImage(Image targetImage, Sprite newSprite)
    {
        targetImage.sprite = newSprite;
    }

    void ImageToImage(Image currentImage, Image newImage)
    {
        currentImage.sprite = newImage.sprite;
    }

    private void Update()
    {
    }
}
