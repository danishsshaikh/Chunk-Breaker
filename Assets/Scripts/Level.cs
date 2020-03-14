using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int breakableBlocks; //for debuggin

    SceneLoad sceneloader;
    private void Start()
    {
        sceneloader = FindObjectOfType<SceneLoad>();
    }
    public void CountBlocks()
    {
        breakableBlocks++;
    }

    public void BlockDestroyed()
    {
        breakableBlocks--;
        if (breakableBlocks <= 0)
        {
            sceneloader.LoadNextScene();
        }
    }
}
