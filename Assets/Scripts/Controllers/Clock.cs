using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Clock : MonoBehaviour
{
    public TMP_Text timeText;

    void Update()
    {
        timeText.text = System.DateTime.Now.ToString("HH:mm");
    }
}
