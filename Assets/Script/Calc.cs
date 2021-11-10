using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Calc : MonoBehaviour
{
    [SerializeField] private InputField firstNumInputField;

    [SerializeField] private InputField secondNumInputField;

    [SerializeField] private Text resultText;

    private double _firstNum;
    private double _secondNum;
    private double _result;

    void Start()
    {
        resultText.text = "Результат";
    }
    
    public void onClickPlus()
    {
        bool allDigitsFirst = firstNumInputField.text.All(char.IsLetter);
        bool allDigitsSecond = secondNumInputField.text.All(char.IsLetter);

        if (!allDigitsFirst && !allDigitsSecond)
        {
            _firstNum = (Convert.ToInt64(firstNumInputField.text));
            _secondNum = (Convert.ToInt64(secondNumInputField.text));

            _result = _firstNum + _secondNum;
            resultText.text = _result.ToString();
        }
        else
        {
            resultText.text = "Введите цифры";
        }
    }
    public void onClickMinus()
    {
        bool allDigitsFirst = firstNumInputField.text.All(char.IsLetter);
        bool allDigitsSecond = secondNumInputField.text.All(char.IsLetter);

        if (!allDigitsFirst && !allDigitsSecond)
        {
            _firstNum = (Convert.ToInt64(firstNumInputField.text));
            _secondNum = (Convert.ToInt64(secondNumInputField.text));

            _result = _firstNum - _secondNum;
            resultText.text = _result.ToString();
        }
        else
        {
            resultText.text = "Введите цифры";
        }
    }
    public void onClickMultiple()
    {
        bool allDigitsFirst = firstNumInputField.text.All(char.IsLetter);
        bool allDigitsSecond = secondNumInputField.text.All(char.IsLetter);

        if (!allDigitsFirst && !allDigitsSecond)
        {
            _firstNum = (Convert.ToInt64(firstNumInputField.text));
            _secondNum = (Convert.ToInt64(secondNumInputField.text));

            _result = _firstNum * _secondNum;
            resultText.text = _result.ToString();
        }
        else
        {
            resultText.text = "Введите цифры";
        }
    }
    public void onClickDivision()
    {
        bool allDigitsFirst = firstNumInputField.text.All(char.IsLetter);
        bool allDigitsSecond = secondNumInputField.text.All(char.IsLetter);

        if (!allDigitsFirst && !allDigitsSecond)
        {
            _firstNum = (Convert.ToInt64(firstNumInputField.text));
            _secondNum = (Convert.ToInt64(secondNumInputField.text));

            _result = _firstNum / _secondNum;
            resultText.text = _result.ToString();
        }
        else
        {
            resultText.text = "Введите цифры";
        }
    }
}
