using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    AudioSource audioSource;
    void Start()
    {
        int musicPlayerCount = FindObjectsOfType<MusicPlayer>().Length;
        //if (musicPlayerCount > 1)
        //{
        //    RestartMusicPlayer();
        //}
        //else {
            DontDestroyOnLoad(this);
        //}

        audioSource = GetComponent<AudioSource>();
        audioSource.volume = PrefsController.GetMasterVolume();
    }
    private void RestartMusicPlayer() {
        gameObject.SetActive(false);
        Destroy(gameObject);
    }
    

    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }
}
