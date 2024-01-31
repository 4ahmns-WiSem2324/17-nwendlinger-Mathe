using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
    public void Quiz()
    {
        SceneManager.LoadScene(2);
    }

    public void Builder()
    {
        SceneManager.LoadScene(1);
    }
}
