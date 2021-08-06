using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    
    [SerializeField] float defaultVolume = 0.1f;
    [SerializeField] int defaultQuestionsPerQuiz = 10;

    void Start()
    {
        Debug.Log(PrefsController.GetMasterVolume());
        volumeSlider.value = PrefsController.GetMasterVolume();
        //difficultySlider.value = PrefsController.GetQuestionsPerQuiz();
    }

    void Update()
    {
        var musicPlayer = FindObjectOfType<MusicPlayer>();
        if (musicPlayer)
        {
            musicPlayer.SetVolume(volumeSlider.value);
        }
        else
        {
            Debug.LogWarning("No Music Player Found");
        }
    }

    public void SaveAndExit()
    {
        PrefsController.SetMasterVolume(volumeSlider.value);
        //PrefsController.SetQuestionsPerQuiz(difficultySlider.value);
        FindObjectOfType<SceneLoader>().LoadMainMenuScene();
    }

    public void SetDefaults()
    {
        volumeSlider.value = defaultVolume;
        //difficultySlider.value = defaultQuestionsPerQuiz;
    }
}
