using UnityEngine;

public class Player4 : MonoBehaviour
{
    private Rigidbody2D rb;
    private float maxvelocity = 7.07f;
    private int X = 0;
    private int Y = 0;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    } 
    public void right()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x + 0.075f, rb.linearVelocity.y);
    }
    public void left()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x - 0.075f, rb.linearVelocity.y);
    }
    public void up()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y + 0.075f);
    }
    public void down()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y - 0.075f);
    }
    public void Update()
    {
            if (rb.linearVelocity.magnitude > maxvelocity)
    {
        rb.linearVelocity = rb.linearVelocity.normalized * maxvelocity;
    }
    if (maxvelocity > 7.07f)
        {
            maxvelocity = maxvelocity - 1f;
        }
    }
    public void boost()
    {
        maxvelocity = 12f;
    }
    private void HandleBroadcast(string OOF4)
    {
        int X = UnityEngine.Random.Range(-2, 2);
        int Y = UnityEngine.Random.Range(-2, 2);
        rb.linearVelocity = new Vector2(rb.linearVelocity.x * X, rb.linearVelocity.y);
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y * Y);
    }
    }