using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OptionsController : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] Slider questionsPerQuizSlider;
    public TextMeshProUGUI questionsCounter;
    public TextMeshProUGUI volumeCounter;

    [SerializeField] float defaultVolume = 0.1f;
    [SerializeField] int defaultQuestionsPerQuiz = 10;

    void Start()
    {
        volumeSlider.value = PrefsController.GetMasterVolume();
        questionsPerQuizSlider.value = PrefsController.GetQuestionsPerQuiz();
    }

    void Update()
    {
        var musicPlayer = FindObjectOfType<MusicPlayer>();
        if (musicPlayer)
        {
            musicPlayer.SetVolume(volumeSlider.value);
            volumeCounter.SetText(Mathf.Round(volumeSlider.value*100).ToString());
        }
        else
        {
            Debug.LogWarning("No Music Player Found");
        }
        var gameStatus = FindObjectOfType<GameSession>();
        if (gameStatus)
        {
            gameStatus.SetQPQ((int)questionsPerQuizSlider.value);
            questionsCounter.SetText(questionsPerQuizSlider.value.ToString());
        }
        else
        {
            Debug.LogWarning("No Game Session Found");
        }
        
    }

    public void SaveAndExit()
    {
        PrefsController.SetMasterVolume(volumeSlider.value);
        PrefsController.SetQuestionsPerQuiz((int)questionsPerQuizSlider.value);
        FindObjectOfType<SceneLoader>().LoadMainMenuScene();
    }

    public void SetDefaults()
    {
        volumeSlider.value = defaultVolume;
        questionsPerQuizSlider.value = defaultQuestionsPerQuiz;
    }
}
