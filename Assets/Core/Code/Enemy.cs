using Unity.VisualScripting;
using UnityEditor;
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


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

    
    private void OnDestroy()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            Score Score = FindFirstObjectByType<Score>();
            if (Score != null)
            {
                Score.AddPoints(200);
            }
        }
    }
}