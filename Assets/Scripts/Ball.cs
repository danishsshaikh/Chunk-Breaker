using UnityEngine;

public class Ball : MonoBehaviour
{

    
    [SerializeField] Paddle paddle1;
    [SerializeField] float xPush = 2f;
    [SerializeField] float yPush = 15f;
    [SerializeField] AudioClip[] ballSounds;

    [SerializeField] float randomFactor = 0.5f;

    
    Vector2 paddletoballvector;
    bool HasStarted = false;

    
    AudioSource myAudioSource;
    Rigidbody2D myRigidBody2D;

    
    void Start()
    {
        paddletoballvector = transform.position - paddle1.transform.position;
        myAudioSource = GetComponent<AudioSource>();
        myRigidBody2D = GetComponent<Rigidbody2D>();
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
            HasStarted = true;
            myRigidBody2D.velocity = new Vector2(xPush, yPush);
        }

    }

    private void LockBallToPadlle()
    {
        Vector2 paddlepos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlepos + paddletoballvector;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 velocityTweak = new Vector2
            (Random.Range(0f, randomFactor),
            Random.Range(0f, randomFactor));
        if (HasStarted)
        {
            AudioClip clip = ballSounds[UnityEngine.Random.Range(0, ballSounds.Length)];
            myAudioSource.PlayOneShot(clip);
            myRigidBody2D.velocity += velocityTweak;
        }
    }
}
