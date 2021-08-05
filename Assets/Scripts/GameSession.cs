using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameSession : MonoBehaviour
{
    public int questionNumber = 1;
    public int questionsCorrect = 0;
    
    public Question[] questionArr;
    public Question currentQuestion;

    
    private void Awake() {
        int gameStatusCount = FindObjectsOfType<GameSession>().Length;
        if (gameStatusCount > 1)
        {
            RestartGame();
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    private void RestartGame() {
        gameObject.SetActive(false);
        Destroy(gameObject);
    }
    private void Start() {
        NextQuestion();
    }
    public void NextQuestion() {
        currentQuestion = questionArr[Random.Range(0, questionArr.Length)];
    }
}
