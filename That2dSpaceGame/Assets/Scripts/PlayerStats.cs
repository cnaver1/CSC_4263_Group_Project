using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public static float hp = 75;
    public static float ammo = 0;
    public static float xp = 0;
    private float startHealth = 100;
    [Header("Unity")]
    public Image healthBar;


    public void Start()
    { if (GlobalControl.Instance.hp != 0) { 
        //hp = GlobalControl.Instance.hp;
        ammo = GlobalControl.Instance.ammo;
        xp = GlobalControl.Instance.xp;
      
    }

}

    void Update()
    {
       
        healthBar.fillAmount = hp / startHealth;
        SavePlayer();

    }

    void takeDamage(float amount)
    {
        hp -= amount;
        healthBar.fillAmount = hp / startHealth;

    }

    public void SavePlayer()
    {
        GlobalControl.Instance.hp = hp;
        GlobalControl.Instance.ammo = ammo;
        GlobalControl.Instance.xp = xp;

 
    }

}
