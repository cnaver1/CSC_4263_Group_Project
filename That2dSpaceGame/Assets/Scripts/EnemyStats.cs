using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStats : MonoBehaviour
{
    public GameObject[] items = new GameObject[3];
    public GameObject DeathEffect;
    Rigidbody2D rb;

    public float currentHealth;
    public float startHealth = 100;
    public float knockBack = 0.1f;

    public AudioSource movement;

    [Header("Unity")]
    public Image healthBar;


    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentHealth = startHealth;
        movement.Play();
        
    }

    void Update()
    {
        healthBar.fillAmount = currentHealth / startHealth;
        if (currentHealth <= 0)
        {

            Death();
        }
    }

    void Death()
    {
        //randome loot drop
        int DropRate = Random.Range(0, 6);
        if (DropRate <= 2) { 
        GameObject drop = Instantiate(items[DropRate], gameObject.transform.position, Quaternion.identity);
        drop.SetActive(true);
        drop.transform.parent = transform.parent;
        
    }
       
        GameObject prefab = Instantiate(DeathEffect, gameObject.transform.position, Quaternion.identity);
        prefab.SetActive(true);
        Destroy(gameObject);
    }

    public void takeDamage(float amount)
    {
        currentHealth -= amount;
        healthBar.fillAmount = currentHealth / startHealth;
    }

    void OnCollisionEnter2D(Collision2D other)

    {
        
        if (other.gameObject.tag == "Bullets")
        {
            Destroy(other.gameObject);
         /*  
            if ((this.transform.position.x - other.transform.position.x) < 0)
            {
                transform.position = new Vector2(transform.position.x - knockBack, transform.position.y);
            }
            else
            {
                transform.position = new Vector2(transform.position.x + knockBack, transform.position.y);
            }
            if ((this.transform.position.y - other.transform.position.y) < 0)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y - knockBack);
            }
            else
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + knockBack);
            }
            */
            takeDamage(25);

        }
    }


}