using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPickup : MonoBehaviour
{
    public GameObject HealthItem;
    public static float hp;
    [Header("Unity")]
    public Image healthBar;
    public float startHealth = 100;
    

    void Update()
    {   
        hp = PlayerStats.hp;
        SavePlayer();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        CurrentObjective.HealthPickup = true;
        float HealthNeeded = 100 - hp;
        if(HealthNeeded < 25)
        {
            hp = 100;
            PlayerStats.hp = hp;
            HealthItem.SetActive(false);
        }
        else
        {
            hp += 25;
            PlayerStats.hp = hp;
            HealthItem.SetActive(false);
        }
    }

    public void SavePlayer()
    {
       
        GlobalControl.Instance.hp = hp;
       


    }
}
