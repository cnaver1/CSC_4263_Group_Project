using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullets : MonoBehaviour
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

    private void Update()
    {
        StartCoroutine(WaitToDestroy());
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            other.gameObject.GetComponent<PlayerStats>().takeDamage(25);

        }


    }

    IEnumerator WaitToDestroy()
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);
    }
}
