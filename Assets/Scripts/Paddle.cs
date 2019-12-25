using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float max = 22.96f;
    [SerializeField] float min = 1.171f;

    private void Update()
    {
        //Debug.Log(Input.mousePosition.x / Screen.width * screenWidthInUnits);

        float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;

        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);

        paddlePos.x = Mathf.Clamp(mousePosInUnits, min, max);

        transform.position = paddlePos;
    }
}
