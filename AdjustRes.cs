using UnityEngine;
using UnityEngine.UI;

public class AdjustRes : MonoBehaviour
{
    public float UnitsSize = 1;
    public Slider slider;

    void Start()
    {
        // Load the saved value from PlayerPrefs
        UnitsSize = PlayerPrefs.GetFloat("UnitsSize", 1);

        // Set the slider value to match the loaded UnitsSize
        slider.value = UnitsSize;
    }

    public void UpdateUnitsSize(float newValue)
    {
        // Update UnitsSize when the slider value changes
        UnitsSize = newValue;

        // Save the new value to PlayerPrefs
        PlayerPrefs.SetFloat("UnitsSize", UnitsSize);

        // Call Save to make sure the value is saved immediately
        PlayerPrefs.Save();
    }
}
