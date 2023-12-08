using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public InputField usernameInputField;
    public InputField passwordInputField;

    private string savedUsernameKey = "SavedUsername";
    private string savedPasswordKey = "SavedPassword";

    private void Start()
    {
        LoadSavedCredentials();
    }

    private void LoadSavedCredentials()
    {
        if (PlayerPrefs.HasKey(savedUsernameKey))
        {
            string savedUsername = PlayerPrefs.GetString(savedUsernameKey);
            usernameInputField.text = savedUsername;
        }

        if (PlayerPrefs.HasKey(savedPasswordKey))
        {
            string savedPassword = PlayerPrefs.GetString(savedPasswordKey);
            passwordInputField.text = savedPassword;
        }
    }

    public void SaveCredentials()
    {
        string username = usernameInputField.text;
        string password = passwordInputField.text;

        PlayerPrefs.SetString(savedUsernameKey, username);
        PlayerPrefs.SetString(savedPasswordKey, password);
        PlayerPrefs.Save();
    }

    public void ClearSavedCredentials()
    {
        PlayerPrefs.DeleteKey(savedUsernameKey);
        PlayerPrefs.DeleteKey(savedPasswordKey);
        PlayerPrefs.Save();

        usernameInputField.text = "";
        passwordInputField.text = "";
    }
}