using UnityEngine;

public class Rigidbody4 : MonoBehaviour
{
    private Rigidbody2D rb;
    public float Ow = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.position.x < -17f || rb.position.x > 17f || rb.position.y > 11f || rb.position.y < -11f)
        {
        Destroy(this);
        Ow = Ow + 1f;
        }
        if (Ow == 3f && this == true)
        {
            
        }
    
    }
}
