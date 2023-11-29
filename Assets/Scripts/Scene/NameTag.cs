using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NameTag : MonoBehaviour
{
    public TMP_Text playerNameText;
    // Start is called before the first frame update
    void Start()
    {
        string playerName = PlayerPrefs.GetString("PlayerName", "Player");
        playerNameText.text = playerName;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(Camera.main.transform);
    }
}
