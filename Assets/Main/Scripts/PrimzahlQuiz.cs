using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PrimzahlQuiz : MonoBehaviour
{

    private bool primeCHECK;
    private int randomNumber;
    public TextMeshProUGUI richtigText, falschText, number;
   

    public void NewNumber()
    {
        randomNumber = Random.Range(1, 1000);
        CheckAndDisplayPrime(randomNumber);
        number.SetText(randomNumber.ToString());
    }

    public void Ja()
    {
        if (primeCHECK == true)
        {
            richtigText.gameObject.SetActive(true);
            falschText.gameObject.SetActive(false);
        }
        else
        {
            richtigText.gameObject.SetActive(false);
            falschText.gameObject.SetActive(true);
        }
    }

    public void Nein()
    {
        if (primeCHECK == false)
        {
            richtigText.gameObject.SetActive(true);
            falschText.gameObject.SetActive(false);
        }
        else
        {
            richtigText.gameObject.SetActive(false);
            falschText.gameObject.SetActive(true);
        }
    }

    private void CheckAndDisplayPrime(float number)
    {
        bool isPrime = IsPrime((int)number);
        primeCHECK = isPrime ? true : false;
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
