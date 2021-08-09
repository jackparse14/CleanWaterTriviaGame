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

    public bool cooldownFinished = true;

    private GameSession gameStatus;
    private SceneLoader sceneLoader;
    private void Start()
    {

        gameStatus = FindObjectOfType<GameSession>();
        sceneLoader = FindObjectOfType<SceneLoader>();
        OutputQuestion();
        if (gameStatus.questionNumber == 1) {
            gameStatus.questionsCorrect = 0;
        }
    }
    public void HandleAnswerClick(int clickedAnswer) {
        gameStatus.questionNumber++;
        if (gameStatus.currentQuestion.correctAnswer == clickedAnswer) {
            gameStatus.questionsCorrect++;
        }

        gameStatus.questionListChosen.Add(gameStatus.currentQuestion);
        gameStatus.questionList.Remove(gameStatus.currentQuestion);

        if (gameStatus.questionNumber == gameStatus.questionsPerQuiz + 1)
        {
            ResetQuestions();
            gameStatus.questionNumber = 1;
            sceneLoader.LoadEndScene();
        }
        else
        {
            sceneLoader.PlayChangeSceneSound();
            gameStatus.NextQuestion();
            OutputQuestion();
        }
    }
    private void ResetQuestions()
    {
        for (int i = 0; i < gameStatus.questionListChosen.Count; i++) {
            gameStatus.questionList.Add(gameStatus.questionListChosen[i]);
        }
        gameStatus.questionListChosen.Clear();
    }
    private void OutputQuestion() {
        questionText.SetText(gameStatus.currentQuestion.questionText);
        questionNumText.SetText(gameStatus.questionNumber.ToString() + "/" + gameStatus.questionsPerQuiz.ToString());

        answerText1.SetText(gameStatus.currentQuestion.answerText1);
        answerText2.SetText(gameStatus.currentQuestion.answerText2);
        answerText3.SetText(gameStatus.currentQuestion.answerText3);
    }

    public IEnumerator AnswerCooldown() {
        yield return new WaitForSeconds(0.5f);
        cooldownFinished = true;
    }
    
}
