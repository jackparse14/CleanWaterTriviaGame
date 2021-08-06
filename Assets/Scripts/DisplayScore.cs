using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private GameSession gameStatus;
    void Start()
    {
        gameStatus = FindObjectOfType<GameSession>();
        scoreText.SetText(gameStatus.questionsCorrect.ToString() + "/" + gameStatus.questionsPerQuiz.ToString());
    }
}
