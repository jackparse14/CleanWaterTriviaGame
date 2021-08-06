using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameSession : MonoBehaviour
{
    public int questionNumber = 1;
    public int questionsCorrect = 0;
    public int questionsPerQuiz;

    public List<Question> questionList = new List<Question>();
    public List<Question> questionListChosen = new List<Question>();

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
        int randQuestionIndex = Random.Range(0, questionList.Count);
        currentQuestion = questionList[randQuestionIndex];
    }
}