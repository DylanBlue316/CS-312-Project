using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{
    static public GameScript S;

    [Header("Set in Inspector")]
    public TextMeshProUGUI ScoreDisplay;



    void Awake()
    {
        S = this;
    }

    void Update()
    {
        ScoreDisplay.text = "Score: " + Player.S.Score;
    }

    public void RestartGame(float delay)
    {
        Invoke("Restart", delay);
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
