using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocialMedia : MonoBehaviour
{
    public void IG()
    {
        Application.OpenURL("https://www.instagram.com/melodykhaokhudjaanjao/");
        Debug.Log("wtf bru");
    }

    public void Twitter()
    {
        Application.OpenURL("https://twitter.com/danssnake");
    }

    public void LinkedIn()
    {
        Application.OpenURL("https://www.linkedin.com/in/danishsshaikh/");
    }
}
