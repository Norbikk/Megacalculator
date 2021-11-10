using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

public class CompareThreeNumScript : MonoBehaviour
{
    [SerializeField] private InputField firstNumInputField;

    [SerializeField] private InputField secondNumInputField;
    
    [SerializeField] private InputField thirdNumInputField;

    [SerializeField] private Text resultText;

    private int _firstNum;
    private int _secondNum;
    private int _thirdNum;
   
    void Start()
    {
       resultText.text = "Результат";
    }

    public void onClickCompare()
    {
        bool allDigitsFirst = firstNumInputField.text.All(char.IsLetter);
        bool allDigitsSecond = secondNumInputField.text.All(char.IsLetter);
        bool allDigitsThird = thirdNumInputField.text.All(char.IsLetter);

        if (!allDigitsFirst && !allDigitsSecond && !allDigitsThird)
        {
            _firstNum = (Convert.ToInt32(firstNumInputField.text)); 
            _secondNum = (Convert.ToInt32(secondNumInputField.text));
            _thirdNum = (Convert.ToInt32(thirdNumInputField.text));

            int max = Math.Max(Math.Max(_firstNum, _secondNum), _thirdNum);
            int min = Math.Min(Math.Min(_firstNum, _secondNum), _thirdNum);

            if (_firstNum == _secondNum && _firstNum == _thirdNum)
            {
                resultText.text = $"Числа равны";
            }
            else
            {
                resultText.text = $"{max}, {_firstNum + _secondNum + _thirdNum - max - min}, {min}";
            }
        }
        else
        {
            resultText.text = "Введите цифры";
        }
    }


}
