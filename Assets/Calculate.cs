using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class Calculate : MonoBehaviour
{
    [SerializeField] private Text resultText;
    [SerializeField] private Text arithmeticOperatorText;
    [SerializeField] private InputField firstNumber;
    [SerializeField] private InputField secondNumber;

    

    public void GetResult()
    {
        if (arithmeticOperatorText.Equals("+"))
        {
         
        }
        else if (arithmeticOperatorText.Equals("-"))
        {

        }
        else if (arithmeticOperatorText.Equals("/"))
        {

        }
        else if(arithmeticOperatorText.Equals("*"))
        {

        }
    }

}
