using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaPickup : MonoBehaviour
{
    public GameObject ManaItem;
    public float mana;
    [Header("Unity")]
    public Image manaBar;
    public float manaStart = 100;



    void Update()
    {
        mana = PlayerStats.mana;
        SavePlayer();
    }

    public void OnTriggerEnter2D(Collider2D collision) { 
    
        float manaNeeded = 100 - mana;
        if (manaNeeded < 25)
        {
            mana = 100;
            PlayerStats.mana = mana;
            ManaItem.SetActive(false);

        }
        else
        {
            mana += 25;
            PlayerStats.mana = mana;
            ManaItem.SetActive(false);

        }
    }

    public void SavePlayer()
    {

        GlobalControl.Instance.mana = mana;



    }
}
