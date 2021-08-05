using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadAnswerScene()
    {
        SceneManager.LoadScene("AnswerScene");
    }
    public void LoadMainMenuScene()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
    public void LoadLearnScene()
    {
        SceneManager.LoadScene("LearnScene");
    }
    public void LoadOptionsScene()
    {
        SceneManager.LoadScene("OptionsScene");
    }
    public void LoadEndScene()
    {
        SceneManager.LoadScene("EndScene");
    }
}
