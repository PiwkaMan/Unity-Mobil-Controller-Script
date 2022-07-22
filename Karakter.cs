using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karakter : MonoBehaviour
{
    public float speed, jumpSpeed;
    Rigidbody2D rb;
    public Joystick joystick;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(joystick.Horizontal * speed, rb.velocity.y);
    }

    public void Jump()
    {
        rb.AddForce(transform.up * jumpSpeed, ForceMode2D.Impulse);
    }
}
