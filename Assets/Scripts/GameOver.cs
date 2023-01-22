using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("Level-1");
    }

    public void QuitGame()
    {
        Debug.Log("quit bro");
        Application.Quit();
    }
}
