using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Begins the Game
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    //Opens the options menu
    public void Options()
    {
        SceneManager.LoadScene("Options");
    }

    // Quits the game
    public void Quit()
    {
        Application.Quit();
    }
}
