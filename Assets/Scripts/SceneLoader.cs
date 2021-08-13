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
        StartCoroutine(PlayChangeSceneSound());
        SceneManager.LoadScene("AnswerScene");
        
    }
    public void LoadMainMenuScene()
    {
        StartCoroutine(PlayChangeSceneSound());
        SceneManager.LoadScene("MainMenuScene");
        
    }
    public void LoadLearnScene()
    {
        StartCoroutine(PlayChangeSceneSound());
        SceneManager.LoadScene("LearnScene");
        
    }
    public void LoadOptionsScene()
    {
        StartCoroutine(PlayChangeSceneSound());
        SceneManager.LoadScene("OptionsScene");
        
    }
    public void LoadEndScene()
    {
        StartCoroutine(PlayChangeSceneSound());
        SceneManager.LoadScene("EndScene");
        
    }
    public IEnumerator PlayChangeSceneSound() {
        audioSource.PlayOneShot(click);
        yield return new WaitWhile(() => audioSource.isPlaying);
    }
}
