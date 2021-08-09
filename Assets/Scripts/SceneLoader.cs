using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public AudioClip click;
    AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void LoadAnswerScene()
    {
        PlayChangeSceneSound();
        SceneManager.LoadScene("AnswerScene");
    }
    public void LoadMainMenuScene()
    {
        PlayChangeSceneSound();
        SceneManager.LoadScene("MainMenuScene");
    }
    public void LoadLearnScene()
    {
        PlayChangeSceneSound();
        SceneManager.LoadScene("LearnScene");
    }
    public void LoadOptionsScene()
    {
        PlayChangeSceneSound();
        SceneManager.LoadScene("OptionsScene");
    }
    public void LoadEndScene()
    {
        PlayChangeSceneSound();
        SceneManager.LoadScene("EndScene");
    }
    public void PlayChangeSceneSound() {
        audioSource.PlayOneShot(click);
    }
}
