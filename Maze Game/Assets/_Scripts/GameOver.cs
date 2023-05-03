using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    //Begins the Game
    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
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
