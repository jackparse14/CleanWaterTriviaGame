using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefsController : MonoBehaviour
{
    const string MASTER_VOLUME_KEY = "master volume";
    const string QUESTIONS_PER_QUIZ_KEY = "questions per quiz";
    const float MIN_VOLUME = 0f;    
    const float MAX_VOLUME = 0.1f;

    const int MIN_QUESTIONS = 5;
    const int MAX_QUESTIONS = 10;

    public static void SetMasterVolume(float volume)
    {
        if (volume >= MIN_VOLUME && volume <= MAX_VOLUME)
        {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        }
        else
        {
            Debug.LogError("Master Volume is out of range");
        }
    }
    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }

    public static void SetQuestionsPerQuiz(int questions) {
        if (questions >= MIN_QUESTIONS && questions <= MAX_QUESTIONS)
        {
            PlayerPrefs.SetInt(QUESTIONS_PER_QUIZ_KEY, questions);
        }
        else
        {
            Debug.LogError("Questions Per Quiz is out of range");
        }
    }
    public static int GetQuestionsPerQuiz()
    {
        return PlayerPrefs.GetInt(QUESTIONS_PER_QUIZ_KEY);
    }
}
