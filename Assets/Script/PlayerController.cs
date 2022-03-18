using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    private AudioSource playerAudio;

    private Text scoreText;
    public static int score;

    public bool GameOver = false;
    public float GravityForce = 10;
    public float Gravity;
    public float vt = -100f; 

    public AudioClip jumpSound;
    public AudioClip crashSound;
    public AudioClip coinSound;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText = GameObject.Find("Text").GetComponent<Text>();
        scoreText.text = "Score: " + score.ToString();
        playerRB = GetComponent<Rigidbody>();
        Physics.gravity *= Gravity;
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRB.AddForce(Vector3.up * GravityForce * Time.deltaTime, ForceMode.Impulse);
            
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }

        if(transform.position.y < -9)
        {
            GameOver = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("CNV"))
        {
            playerAudio.PlayOneShot(crashSound, 1.0f);
            GameOver = true;                     
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Finish")
        {
            playerAudio.PlayOneShot(coinSound, 0.5f);
            score++;
            scoreText.text = "Score: " + score.ToString();
        }

    }
}
