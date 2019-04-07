using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    float speed = 1f;

    Rigidbody2D rb;

    GameObject thePlayer;
    Vector2 direction;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        thePlayer = GameObject.FindGameObjectWithTag("Player");
        direction = (thePlayer.transform.position - transform.position).normalized * speed;
        rb.velocity = new Vector2(direction.x, direction.y);

        
    }


      public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            other.gameObject.GetComponent<PlayerStats>().takeDamage(25);

        }
    }
}
