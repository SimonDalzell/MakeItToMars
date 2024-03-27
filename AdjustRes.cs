using UnityEngine;
using UnityEngine.UI;

public class AdjustRes : MonoBehaviour
{
    public float UnitsSize = 1;
    public Slider slider;

    void Start()
    {
        //Get users resolution
        UnitsSize = PlayerPrefs.GetFloat("UnitsSize", 1);
        slider.value = UnitsSize;
    }

    public void UpdateUnitsSize(float newValue)
    {
        //Set users resolution for camera scaling
        UnitsSize = newValue;
        PlayerPrefs.SetFloat("UnitsSize", UnitsSize);
        PlayerPrefs.Save();
    }
}
