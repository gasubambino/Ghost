using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float xMovement = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(xMovement * speed, rb.velocity.y);
        if (xMovement == 1)
        {
            Vector3 rotator = new Vector3(transform.rotation.x,0,transform.rotation.z);
            transform.rotation = Quaternion.Euler(rotator); 
        }
        if (xMovement == -1)
        {
            Vector3 rotator = new Vector3(transform.rotation.x, 180f, transform.rotation.z);
            transform.rotation = Quaternion.Euler(rotator);
        }
    }
}
