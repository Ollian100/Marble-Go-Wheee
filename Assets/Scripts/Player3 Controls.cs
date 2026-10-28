using System.Numerics;
using UnityEngine;

public class PlayerThreeControls : MonoBehaviour
{
    private Rigidbody2D rb;
    public float Ow = 0f;
    private float maxvelocity = 7.07f;
    private int X = 0;
    private int Y = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.L))
        {
            rb.linearVelocity = new UnityEngine.Vector2(rb.linearVelocity.x + 0.075f, rb.linearVelocity.y);
        }
        if (Input.GetKey(KeyCode.J))
        {
            rb.linearVelocity = new UnityEngine.Vector2(rb.linearVelocity.x - 0.075f, rb.linearVelocity.y);
        }
        if (Input.GetKey(KeyCode.I))
        {
            rb.linearVelocity = new UnityEngine.Vector2(rb.linearVelocity.x, rb.linearVelocity.y + 0.075f);
        }
        if(Input.GetKey(KeyCode.K))
        {
            rb.linearVelocity = new UnityEngine.Vector2(rb.linearVelocity.x, rb.linearVelocity.y - 0.075f);
        }
        if (rb.linearVelocity.magnitude > maxvelocity)
        {
            rb.linearVelocity = rb.linearVelocity.normalized * maxvelocity;
        }
        if (Input.GetKey(KeyCode.Space))
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
    private void HandleBroadcast(string OOF3)
    {
        int X = UnityEngine.Random.Range(-2, 2);
        int Y = UnityEngine.Random.Range(-2, 2);
        rb.linearVelocity = new UnityEngine.Vector2(rb.linearVelocity.x * X, rb.linearVelocity.y);
        rb.linearVelocity = new UnityEngine.Vector2(rb.linearVelocity.x, rb.linearVelocity.y * Y);
    }
}
