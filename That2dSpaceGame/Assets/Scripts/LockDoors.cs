using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockDoors : MonoBehaviour
{
    public static int enemyCount;
    public GameObject OpenDoor;
    public GameObject ClosedDoor;
    int count;

 

    void Start()
    {
        OpenDoor.SetActive(false);
        ClosedDoor.SetActive(true);
      
    }

    void Update()
    {
        GameObject[] EnemiesLeft = GameObject.FindGameObjectsWithTag("Enemy");
        if(EnemiesLeft.Length == 0)
        {
            EnemiesDead();
        }
    }

  

    void EnemiesDead()
    {
        
            OpenDoor.SetActive(true);
            ClosedDoor.SetActive(false);
    }
}
