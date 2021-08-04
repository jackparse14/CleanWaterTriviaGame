using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameSession : MonoBehaviour
{
    public Question[] questionArr;
    private Question outputQuestion;
    public TextMeshProUGUI questionText;
    private void Start()
    {
        outputQuestion = ChooseRandomQuestion();
        questionText.SetText(outputQuestion.questionText);
    }
    Question ChooseRandomQuestion() {
        return questionArr[Random.Range(0, questionArr.Length)];
    }
    
}
