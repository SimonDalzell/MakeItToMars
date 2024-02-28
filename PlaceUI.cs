using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaceUI : MonoBehaviour
{
    
    public Text Progress;
    public Text Time;


    void Start()
    {
        RectTransform rectTransform = Progress.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = new Vector2((Screen.width / 5f)/2, (Screen.height - rectTransform.sizeDelta.y / 2f)/5);
    }

    void PlaceTextAtTop(Text text)
    {
       
    }
}


