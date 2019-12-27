using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    
    [SerializeField] Paddle paddle1;
    [SerializeField] float xPush = 2f;
    [SerializeField] float yPush = 15f;
    [SerializeField] AudioClip[] ballSounds;

    
    Vector2 paddletoballvector;
    bool HasStarted = false;

    
    AudioSource myAudioSource;

    
    void Start()
    {
        paddletoballvector = transform.position - paddle1.transform.position;
        myAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (HasStarted == false)
        {
            LockBallToPadlle();
            LounchBallOnMouseClick();
        }

    }

    private void LounchBallOnMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(xPush, yPush);
            HasStarted = true;
        }

    }

    private void LockBallToPadlle()
    {
        Vector2 paddlepos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlepos + paddletoballvector;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (HasStarted)
        {
            AudioClip clip = ballSounds[UnityEngine.Random.Range(0, ballSounds.Length)];
            myAudioSource.PlayOneShot(clip);
        }
    }
}
