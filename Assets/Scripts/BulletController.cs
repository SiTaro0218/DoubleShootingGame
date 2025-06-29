using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 20f;

    public GameObject wallObject;

    Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = transform.up * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this);
    }
}
