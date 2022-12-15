using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class Calculate : MonoBehaviour
{
    [SerializeField] private Text resultText;
    [SerializeField] private InputField firstNumber;
    [SerializeField] private InputField secondNumber;

    private int result = 0;

    public void AddUpNumber()
    {
        result = Convert.ToInt32(firstNumber.text) + Convert.ToInt32(secondNumber.text);
    }

    public void Split()
    {
        result = Convert.ToInt32(firstNumber.text) / Convert.ToInt32(secondNumber.text);
    }

    public void Multiply()
    {
        result = Convert.ToInt32(firstNumber.text) * Convert.ToInt32(secondNumber.text);
    }

    public void Subtract()
    {
        result = Convert.ToInt32(firstNumber.text) - Convert.ToInt32(secondNumber.text);
    }

    public void Show()
    {
        resultText.text = result.ToString();
    }

}
