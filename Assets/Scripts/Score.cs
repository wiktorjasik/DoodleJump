using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text scoreText, highScoreText;
    public Transform playerPosition;
    public Rigidbody2D playerRB;
    float pos = 2f;
    int score = 0;
    int x = 10;

	// Use this for initialization
	void Start ()
    {
        scoreText.text = score.ToString();
        highScoreText.text = "HighScore: " + PlayerPrefs.GetInt("HighScore").ToString();
    }
	
	// Update is called once per frame
	void Update ()
    {
        scoreText.text = score.ToString();
        if (playerPosition.position.y > pos)
        {
            score++;
            pos += 2;
        }

        if (score == x)
        {
            playerRB.gravityScale += .2f;
            Platform.jumpForce += .6f;
            x += 10;
        }
        if (PlayerPrefs.GetInt("HighScore")<score)
        {
            highScoreText.text = "HighScore: " + score.ToString();
            PlayerPrefs.SetInt("HighScore", score);
        }
	}
}
