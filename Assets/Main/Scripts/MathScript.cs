using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MathScript : MonoBehaviour
{
    public TMP_InputField numInputField1;
    public TMP_InputField numInputField2;
    public TextMeshProUGUI resultText;

    public void Add()
    {
        float num1, num2;

        if (float.TryParse(numInputField1.text, out num1) && float.TryParse(numInputField2.text, out num2))
        {
            float result = num1 + num2;
            resultText.text = "Ergebnis: " + result;
        }
        else
        {
            resultText.text = "Invalid input. Please enter valid numbers.";
        }
    }

    public void Subtract()
    {
        float num1, num2;

        if (float.TryParse(numInputField1.text, out num1) && float.TryParse(numInputField2.text, out num2))
        {
            float result = num1 - num2;
            resultText.text = "Ergebnis: " + result;
        }
        else
        {
            resultText.text = "Invalid input. Please enter valid numbers.";
        }
    }

    public void Multiply()
    {
        float num1, num2;

        if (float.TryParse(numInputField1.text, out num1) && float.TryParse(numInputField2.text, out num2))
        {
            float result = num1 * num2;
            resultText.text = "Ergebnis: " + result;
        }
        else
        {
            resultText.text = "Invalid input. Please enter valid numbers.";
        }
    }

    public void Divide()
    {
        float num1, num2;

        if (float.TryParse(numInputField1.text, out num1) && float.TryParse(numInputField2.text, out num2))
        {
            float result = num1 / num2;
            resultText.text = "Ergebnis: " + result;
        }
        else
        {
            resultText.text = "Invalid input. Please enter valid numbers.";
        }
    }
}
