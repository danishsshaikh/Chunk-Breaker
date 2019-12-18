using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("LevelScene");
    }

    public void endGame()
    {
        Application.Quit();
    }

    public void aboutMe()
    {
        SceneManager.LoadScene("MEH");
    }

    public void goBack()
    {
        SceneManager.LoadScene("Main Screen");
    }
}
