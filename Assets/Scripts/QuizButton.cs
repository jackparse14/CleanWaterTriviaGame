using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizButton : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) {
        Player player = collision.gameObject.GetComponent<Player>();
        if (!player)
        {
            return;
        }
        else
        {
            FindObjectOfType<SceneLoader>().LoadAnswerScene();
        }
    }
}
