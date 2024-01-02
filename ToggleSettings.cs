using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSettings : MonoBehaviour
{
    public GameObject SettingsMenu;

    public void ShowSettings()
    {
        SettingsMenu.SetActive(true);

    }

    public void HideSettings()
    {
        SettingsMenu.SetActive(false);

    }
}
