using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Damage : MonoBehaviour
{
    public GameObject isAttack;
   public float enemyHealth;

 
    private IEnumerator Attack()
    {

        
        yield return new WaitForSeconds(3);
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<EnemyStats>().takeDamage(25);
        }   
    }

    
}
