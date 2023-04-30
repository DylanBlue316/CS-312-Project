using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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
}
