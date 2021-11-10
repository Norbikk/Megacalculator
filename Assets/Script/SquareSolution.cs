
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

public class SquareSolution : MonoBehaviour
{
    [SerializeField] private InputField firstNumInputField;

    [SerializeField] private InputField secondNumInputField;

    [SerializeField] private InputField thirdNumInputField;

    [SerializeField] private Text resultText;

    private double _firstNum;
    private double _secondNum;
    private double _thirdNum;
    private double _discriminant;
    double x1, x2;

    void Start()
    {
        resultText.text = "Результат";
    }

    public void onClickSolution()
    {
        bool allDigitsFirst = firstNumInputField.text.All(char.IsLetter);
        bool allDigitsSecond = secondNumInputField.text.All(char.IsLetter);
        bool allDigitsThird = thirdNumInputField.text.All(char.IsLetter);

        if (!allDigitsFirst && !allDigitsSecond && !allDigitsThird)
        {
            _firstNum = (Convert.ToInt64(firstNumInputField.text));
            _secondNum = (Convert.ToInt64(secondNumInputField.text));
            _thirdNum = (Convert.ToInt64(thirdNumInputField.text));

            if (_firstNum == 0)
            {
                resultText.text = "Число a не может равняться нулю";
                return;
            }

            _discriminant = Math.Pow(_secondNum, 2) - 4 * _firstNum * _thirdNum;

            if (_discriminant < 0)
            {
                resultText.text = "Уравнение не имеет корней";
            }
            else
            {
                if (_discriminant == 0)
                {
                    x1 = -_secondNum / (2 * _firstNum);
                    x1 = x2;
                }
                else
                {
                    x1 = (-_secondNum - Math.Sqrt(_discriminant)) / (2 * _firstNum);
                    x2 = (-_secondNum + Math.Sqrt(_discriminant)) / (2 * _firstNum);
                }

                resultText.text = $" x1 = {x1}, x2 = {x2}";
            }
            

        }
        else
        {
            resultText.text = "Введите цифры";
        }
    }
}
