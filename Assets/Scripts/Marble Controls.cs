using UnityEngine;

public class MarbleControls : MonoBehaviour
{
    public float MaxVelocity = Mathf.Sqrt(rb.Velociy.x^2 + rb.Velocity.y^2);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (MaxVelocity > 7.07f)
        {
            set MaxVelocity = 7.07f;
        }

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        rb.Velocity.x = rb.Velocity.x + 0.1f;
        if (Input.GetKey(KeyCode.LeftArrow))
        rb.velocity.x = rb.velocity.x - 0.1f;
    }
}