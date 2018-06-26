using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{

    public float movementSpeed = 10f;
    public Transform gameOverPoint;
    public GameObject leftButton, rightButton;

    Rigidbody2D rb;

    float movement = 0f;
    float x = 0f;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Input.simulateMouseWithTouches = enabled;
        if(Application.platform == RuntimePlatform.Android)
        {
            rightButton.SetActive(true);
            leftButton.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed + movementSpeed * x;
        if (transform.position.y < gameOverPoint.transform.position.y)
        {
            SceneManager.LoadScene("MainLevel");
            Platform.jumpForce = 10f;
        }
    }

    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
    }

    public void TurnRight()
    {
        x = Mathf.Lerp(0f, 1f, Mathf.Lerp(0.1f, 1f, 0.6f));
    }

    public void TurnLeft()
    {
        x = Mathf.Lerp(0f, -1f, Mathf.Lerp(0.1f, 1f, 0.6f));
    }

    public void ResetX()
    {
        x = 0f;
    }
}
