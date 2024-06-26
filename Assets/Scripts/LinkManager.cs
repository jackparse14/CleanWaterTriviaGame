using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkManager : MonoBehaviour
{
    SceneLoader sceneLoader;
    private void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }
    public void OpenWaterProject()
    {
        StartCoroutine(sceneLoader.PlayChangeSceneSound());
        Application.OpenURL("https://thewaterproject.org/why-water/health");
    }
    public void OpenBorgenMagazine()
    {
        StartCoroutine(sceneLoader.PlayChangeSceneSound());
        Application.OpenURL("https://www.borgenmagazine.com/10-clean-water-solutions/");
    }
    public void OpenWorldVision()
    {
        StartCoroutine(sceneLoader.PlayChangeSceneSound());
        Application.OpenURL("https://www.worldvision.org/clean-water-news-stories/walk-water-6k");
    }
}
