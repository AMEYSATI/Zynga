using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float duration = 10f; // The duration of the power-up effect in seconds
    public string effectType="immunity"; // The type of effect this power-up provides (e.g. "immunity")
   
    public float speed = 2f;   // The speed of the enemy in units per second
    public float lifeTime = 5f; // The time in seconds before the enemy is destroyed
    public float speedIncreaseInterval = 10f;   // The time in seconds between speed increases
    public float speedIncreaseAmount = 5f;    // The amount to increase the speed by

    private Rigidbody2D rb;   // The rigidbody component of the enemy
    private float timeSinceLastSpeedIncrease = 0f;   // The time since the last speed increase

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
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


    // When the player collides with the power-up, activate the power-up effect and destroy the power-up object
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ActivateEffect(collision);
            foreach (Transform child in transform)
            {
                Destroy(child.gameObject);
            }
        }
    }

    private IEnumerator immunityCoroutine;
    // Activate the power-up effect based on its type
    private void ActivateEffect(Collider2D collision)
    {
        switch (effectType)
        {
            case "immunity":
                if (immunityCoroutine != null) StopCoroutine(immunityCoroutine);
                immunityCoroutine = ImmunityEffect(collision);
                StartCoroutine(immunityCoroutine);
                break;
                // Add more cases here for additional power-up types
        }
    }

    // Provide the player with immunity to damage for the duration of the power-up effect
    private IEnumerator ImmunityEffect(Collider2D collision)
    {
        collision.gameObject.GetComponent<PlayerHealth>().isImmune = true;
        yield return new WaitForSeconds(duration);
        collision.gameObject.GetComponent<PlayerHealth>().isImmune = false;
    }
}
