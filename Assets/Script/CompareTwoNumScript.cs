using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

public class CompareTwoNumScript : MonoBehaviour
{
    [SerializeField] private InputField firstNumInputField;

    [SerializeField] private InputField secondNumInputField;

    [SerializeField] private Text resultText;

    private int _firstNum;
    private int _secondNum;

    void Start()
    {
        resultText.text = "Результат";
    }

    public void OnClickCompare()
    {
        bool allDigitsFirst = firstNumInputField.text.All(char.IsLetter);
        bool allDigitsSecond = secondNumInputField.text.All(char.IsLetter);
      
        if (!allDigitsFirst && !allDigitsSecond)
        { 
            _firstNum = (Convert.ToInt32(firstNumInputField.text)); 
            _secondNum = (Convert.ToInt32(secondNumInputField.text));

            int max = Math.Max(_firstNum, _secondNum);
            int min = Math.Min(_firstNum, _secondNum);

            if (_firstNum == _secondNum)
            {
                resultText.text = $"Числа {_firstNum} и {_secondNum} равны";
            }
            else
            {
                resultText.text = $"Максимальное число = {max}, Минимальное число = {min}"; //Можно оставить что-то одно, если противоречит заданию, но так вроде больше инфы
            }
        }
        else
        {
            resultText.text = "Введите цифры";
        }

    }
}
/// Если не подходит, можно так ///
/*if (_firstNum > _secondNum)
{
    resultText.text = $"Число a={_firstNum} больше b={_secondNum}";
}

if (_firstNum < _secondNum)
{
    resultText.text = $"Число b = {_secondNum} больше a = {_firstNum}";
}
else if (_firstNum == _secondNum)
{
    resultText.text = $"Числа a={_firstNum} и b={_secondNum} равны";
}*/