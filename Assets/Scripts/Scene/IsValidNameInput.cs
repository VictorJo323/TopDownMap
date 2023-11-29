using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class IsValidNameInput : MonoBehaviour
{
    public TMP_InputField nameField;
    public Button startButton;
    // Start is called before the first frame update
    
    private void Update()
    {
        string playerName = nameField.text;
        if (playerName.Length >= 2 && playerName.Length <= 10)
        {
            PlayerPrefs.SetString("PlayerName", playerName);
            startButton.GetComponent<Button>().interactable = true;
        }
        else
        {
            startButton.GetComponent<Button>().interactable = false;
        }        
    }
}
