using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float minSpeed = 2f;
    public float maxSpeed = 5f;
    private float speed;
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = Random.Range(minSpeed, maxSpeed);
    }

    void FixedUpdate()
    {
        rb.linearVelocity = Vector2.left * speed;
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}