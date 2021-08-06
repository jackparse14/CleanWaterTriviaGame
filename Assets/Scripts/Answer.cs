using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Answer : MonoBehaviour
{
    QuestionManager questionManager;
    public int answerNum;
    
    private void Start()
    {
        questionManager = FindObjectOfType<QuestionManager>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();
        if (!player)
        {
            return;
        }
        else {
            if (questionManager.cooldownFinished)
            {
                questionManager.cooldownFinished = false;
                questionManager.HandleAnswerClick(answerNum);
                StartCoroutine(questionManager.AnswerCooldown());
            }
        }
    }
}
