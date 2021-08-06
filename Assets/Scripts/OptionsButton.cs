using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsButton : MonoBehaviour
{
    SceneLoader sceneLoader;
    private void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();
        if (!player)
        {
            return;
        }
        else
        {
            sceneLoader.LoadOptionsScene();
        }
    }
}
