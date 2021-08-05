using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestionManager : MonoBehaviour
{
    public TextMeshProUGUI questionText;
    public TextMeshProUGUI questionNumText;
    

    public TextMeshProUGUI answerText1;
    public TextMeshProUGUI answerText2;
    public TextMeshProUGUI answerText3;

    private GameSession gameStatus;
    private SceneLoader sceneLoader;
    private void Start()
    {
        gameStatus = FindObjectOfType<GameSession>();
        sceneLoader = FindObjectOfType<SceneLoader>();
        

        questionText.SetText(gameStatus.currentQuestion.questionText);
        questionNumText.SetText(gameStatus.questionNumber.ToString() + "/10");

        answerText1.SetText(gameStatus.currentQuestion.answerText1);
        answerText2.SetText(gameStatus.currentQuestion.answerText2);
        answerText3.SetText(gameStatus.currentQuestion.answerText3);
        if (gameStatus.questionNumber == 1) {
            gameStatus.questionsCorrect = 0;
        }
    }
    public void HandleAnswerClick(int clickedAnswer) {
        gameStatus.questionNumber++;
        if (gameStatus.currentQuestion.correctAnswer == clickedAnswer) {
            gameStatus.questionsCorrect++;
        }
        gameStatus.NextQuestion();
        if (gameStatus.questionNumber == 11)
        {
            
            gameStatus.questionNumber = 1;
            sceneLoader.LoadEndScene();
        }
        else
        {
            sceneLoader.LoadAnswerScene();
        }
    }
}
