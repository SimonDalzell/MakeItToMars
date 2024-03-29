using UnityEngine;
using UnityEngine.UI;

public class ChangeImageButton : MonoBehaviour
{
    public Sprite originalSprite; 
    public Sprite pressedSprite;

    private Image image;

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    private void Start()
    {
        UpdateImageSprite();
    }

    private void Update()
    {
        UpdateImageSprite();
    }
    //Updates mute button to show that it has muted based on users choice
    private void UpdateImageSprite()
    {
        int isMuted = PlayerPrefs.GetInt("IsMuted", 0);

        if (isMuted == 1)
        {
            image.sprite = pressedSprite;
        }
        else
        {
            image.sprite = originalSprite;
        }
    }

}
