using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidthInUnits = 16f;

    private void Update()
    {
        Debug.Log(Input.mousePosition.x / Screen.width * screenWidthInUnits);
    }
}
