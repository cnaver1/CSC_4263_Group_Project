using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public int health = 100;
    private int currentHealth;
  
    void Start()
    {
        currentHealth = health;

    }
    void Update()
    {
        if (currentHealth <= 0){
            Death();
        }
    }
 
    private void Death()
    {
        Destroy(gameObject);
    }

    public void Damage(int damage)
    {
        currentHealth -= damage;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Projectile"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
