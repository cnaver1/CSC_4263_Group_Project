using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    Rigidbody2D rb;
    public static float hp = 100;
    public static float mana = 100;
    public static float xp = 0;
    private float startHealth = 100;
    public float knockBack = 0.5f;
    [Header("Unity")]
    public Image healthBar;
    public Image manaBar;


    public void Start()
    { if (GlobalControl.Instance.hp != 0) { 
        //hp = GlobalControl.Instance.hp;
        mana = GlobalControl.Instance.mana;
        xp = GlobalControl.Instance.xp;
      
    }
        rb = GetComponent<Rigidbody2D>();
}

    void Update()
    {
       
        healthBar.fillAmount = hp / startHealth;
        manaBar.fillAmount = mana / 100;

        SavePlayer();

        if(hp <= 0)
        {
            
        }
    }

    void Dead()
    {
        Destroy(gameObject);
    }

    public void takeDamage(float amount)
    {
        hp -= amount;
        healthBar.fillAmount = hp / startHealth;

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Touching Enemy
        if (other.gameObject.CompareTag("Enemy"))
        {
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

            takeDamage(25);
        }

        if (other.gameObject.CompareTag("EnemyBullet"))
        {
            takeDamage(25);
            Destroy(other.gameObject);
        }
    }

       
    

    public void SavePlayer()
    {
        GlobalControl.Instance.hp = hp;
        GlobalControl.Instance.mana = mana;
        GlobalControl.Instance.xp = xp;

 
    }

   



}
