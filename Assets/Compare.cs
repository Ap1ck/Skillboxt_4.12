using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Compare : MonoBehaviour
{
    [SerializeField] private Text text;
    [SerializeField] private InputField inputField;

    private int value = 0;

    private void Start()
    {
        value = UnityEngine.Random.Range(0,51);
    }

    public void CheckClicked()
    {
        if (inputField.text.Equals(value.ToString()))
        {
            text.text = "Верно";
        }
        else if (Convert.ToInt32(inputField.text) > value)
        {
            text.text = "Загаданное число меньше";
        }
        else if(Convert.ToInt32(inputField.text)<value)
        {
            text.text = "Загаданное число больше";
        }
    }
}
