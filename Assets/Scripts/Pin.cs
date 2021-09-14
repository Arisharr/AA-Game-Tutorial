using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    public bool isPinned = false;
    public float ShootSpeed;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (!isPinned)
        {
            rb.MovePosition(rb.position + Vector2.up * ShootSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Rotator"))
        {
            transform.SetParent(collision.transform);
            FindObjectOfType<GameManager>().Score++;
            isPinned = true;
        }

        else if (collision.CompareTag("Pin"))
        {
            FindObjectOfType<GameManager>().GameOverMethod();
        }
    }
}
