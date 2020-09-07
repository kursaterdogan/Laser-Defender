using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    GameSession gameSession;

    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        gameSession = FindObjectOfType<GameSession>();
    }

    void Update()
    {
        scoreText.text = gameSession.GetScore().ToString();
    }

}
