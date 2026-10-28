using System;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.Rendering;

public class MarbleControls : MonoBehaviour
{
    private Rigidbody2D rb;
    public static float Ow = 0f;
    public static bool Win = false;
    private float maxvelocity = 7.07f;
    private int X = 0;
    private int Y = 0;
    //It won't change when i use the speed boost
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x + 0.075f, rb.linearVelocity.y);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x - 0.075f, rb.linearVelocity.y);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y + 0.075f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y - 0.075f);
        }
        if (rb.linearVelocity.magnitude > maxvelocity)
        {
            rb.linearVelocity = rb.linearVelocity.normalized * maxvelocity;
        }
        if (Input.GetKey(KeyCode.RightShift))
        {
            maxvelocity = 12f;
        }
        if (maxvelocity > 7.07f)
        {
            maxvelocity = maxvelocity - 1f;
        }
        if (rb.position.x < -17f || rb.position.x > 17f || rb.position.y > 11f || rb.position.y < -11f)
        {
        Destroy(this);
        Ow = Ow + 1f;
        }
    }
    private void HandleBroadcast(string OOF1)
    {
        int X = UnityEngine.Random.Range(-2, 2);
        int Y = UnityEngine.Random.Range(-2, 2);
        rb.linearVelocity = new Vector2(rb.linearVelocity.x * X, rb.linearVelocity.y);
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y * Y);
    }
}