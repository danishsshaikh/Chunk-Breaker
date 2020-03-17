using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    public void lvlOne()
    {
        SceneManager.LoadScene("01-Level");
    }

    public void lvlTwo()
    {
        SceneManager.LoadScene("02-Level");
    }

    public void lvlThree()
    {
        SceneManager.LoadScene("03-Level");
    }

    public void lvlFour()
    {
        SceneManager.LoadScene("04-Level");
    }

    public void lvlFive()
    {
        SceneManager.LoadScene("05-Level");
    }
}
