using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MathScript : MonoBehaviour
{
    public TMP_InputField numInputField1;
    public TMP_InputField numInputField2;
    public TextMeshProUGUI resultText;
    public TextMeshProUGUI primeFeedback;

    public void Add()
    {
        float num1, num2;

        if (float.TryParse(numInputField1.text, out num1) && float.TryParse(numInputField2.text, out num2))
        {
            float result = num1 + num2;
            resultText.text = "Ergebnis: " + result;
            CheckAndDisplayPrime(result);
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
            CheckAndDisplayPrime(result);
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
            CheckAndDisplayPrime(result);
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
            CheckAndDisplayPrime(result);
        }
        else
        {
            resultText.text = "Invalid input. Please enter valid numbers.";
        }
    }

    private void CheckAndDisplayPrime(float number)
    {
        bool isPrime = IsPrime((int)number);
        primeFeedback.text = isPrime ? "Prime" : "Not Prime";
    }

    private bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        if (number <= 3)
        {
            return true;
        }

        if (number % 2 == 0 || number % 3 == 0)
        {
            return false;
        }

        for (int i = 5; i * i <= number; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
            {
                return false;
            }
        }

        return true;
    }

    public void BackButton()
    {
        SceneManager.LoadScene(0);
    }

    
}