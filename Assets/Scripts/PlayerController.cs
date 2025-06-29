using System.Xml.Serialization;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float speed = 1.0f;

    float axisH = 0.0f;

    Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }

        axisH = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(axisH * speed, rb.linearVelocity.y);
    }

    void Fire()
    {
        // Instantiate a bullet at the player's position and rotation
        GameObject newBullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

    }
}
