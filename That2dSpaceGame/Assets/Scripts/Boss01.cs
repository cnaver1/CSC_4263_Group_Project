using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Boss01 : MonoBehaviour
{
    [SerializeField]
    public GameObject bullet;
   public GameObject DeathEffect;

    public float startHealth = 10;
    public float currentHealth;
    float fireRate;
    float nextFire;
    public GameObject healthUI;

    [Header("Unity")]
    public Image healthBar;

    void Start()
    {
        fireRate = 1f;
        nextFire = Time.time;
        currentHealth = startHealth;
        healthUI.SetActive(true);
      
    }

    void Update()
    {
        CheckFire();
        healthBar.fillAmount = currentHealth / startHealth;
        if (currentHealth <= 0)
        {
            Death();
        }
    }

    void CheckFire()
    {
        if(Time.time > nextFire)
        {
            GameObject b = Instantiate(bullet, transform.position, Quaternion.identity);
            b.tag = "EnemyBullet";
            nextFire = Time.time + fireRate;
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
        GameObject prefab = Instantiate(DeathEffect, gameObject.transform.position, Quaternion.identity);
        prefab.SetActive(true);
        
        healthUI.SetActive(false);
        Destroy(gameObject);
        
    }

}
