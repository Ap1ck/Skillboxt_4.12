using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Compare : MonoBehaviour
{
    [SerializeField] private Text text;
    [SerializeField] private InputField inputField;
    [SerializeField] private InputField inputField2;

    public void TwoNumbersCompare()
    {
        if (Convert.ToInt32(inputField.text) > Convert.ToInt32(inputField2.text))
        {
            text.text = inputField.text;
        }
        else if (Convert.ToInt32(inputField.text) < Convert.ToInt32(inputField2.text))
        {
            text.text = inputField2.text;
        }
        else
        {
            text.text = "Числа равны";
        }
    }
}
