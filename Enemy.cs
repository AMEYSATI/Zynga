using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f;   // The speed of the enemy in units per second
    public float lifeTime = 5f; // The time in seconds before the enemy is destroyed
    public float speedIncreaseInterval = 10f;   // The time in seconds between speed increases
    public float speedIncreaseAmount = 5f;    // The amount to increase the speed by

    private Rigidbody2D rb;   // The rigidbody component of the enemy
    private float timeSinceLastSpeedIncrease = 0f;   // The time since the last speed increase

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   // Get the rigidbody component
        rb.AddForce(transform.up * speed, ForceMode2D.Impulse);   // Apply a force in the y-direction

        Destroy(gameObject, lifeTime);  // Destroy the enemy after the specified lifetime
    }

    // Update is called once per frame
    void Update()
    {
        // Increase the speed of the enemy over time
        timeSinceLastSpeedIncrease += Time.deltaTime;
        if (timeSinceLastSpeedIncrease >= speedIncreaseInterval)
        {
            speed += speedIncreaseAmount;
            rb.velocity = transform.up * speed;
            timeSinceLastSpeedIncrease = 0f;
        }
    }
}
