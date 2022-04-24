using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Simulation");
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene("Simulation");
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
