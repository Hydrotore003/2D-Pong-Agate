using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    public Text Author;

    public void PlayGame()
    {
        SceneManager.LoadScene("Pong");
    }

    public void OpenAuthor()
    {
        Debug.Log("Created By Farhan Annur Mahmudi");
    }
}
