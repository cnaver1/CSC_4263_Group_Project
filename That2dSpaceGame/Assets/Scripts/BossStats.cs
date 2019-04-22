using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BossStats : MonoBehaviour
{
    [SerializeField]
   public GameObject DeathEffect;

    public float startHealth = 200;
    public float currentHealth;
    public float fireRate;
    public GameObject healthUI;

    public AudioSource attack;
    public AudioSource movement;

    [Header("Unity")]
    public Image healthBar;

    void Start()
    {
        currentHealth = startHealth;
        healthUI.SetActive(true);
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

   


     void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bullets"))
        {
            Destroy(other.gameObject);
            takeDamage(10);
        }
       
    }

    public void takeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.fillAmount = currentHealth / startHealth;
    }

    void Death()
    {
        movement.Pause();
        GameObject prefab = Instantiate(DeathEffect, gameObject.transform.position, Quaternion.identity);
        prefab.SetActive(true);
        
        healthUI.SetActive(false);
        Destroy(gameObject);
        movement.Pause();
        
    }

   
}
