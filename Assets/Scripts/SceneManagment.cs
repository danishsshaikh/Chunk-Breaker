using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("LevelScene");
    }
}
