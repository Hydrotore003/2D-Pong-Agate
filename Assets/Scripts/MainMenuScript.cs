using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenuScript : MonoBehaviour
{
    public string Url;

    public void PlayGame()
    {
        SceneManager.LoadScene("Pong");
    }

    public void CreditScene()
    {
        SceneManager.LoadScene("Credit");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void github()
    {
        Application.OpenURL(Url);
    }

    public void HowtoPlay()
    {
        SceneManager.LoadScene("How to Play");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
