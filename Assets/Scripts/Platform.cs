using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {

    public static float jumpForce = 10f;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.relativeVelocity.y <=0f)
        {
            Rigidbody2D rb = col.collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
            }
        }        
    }
}
