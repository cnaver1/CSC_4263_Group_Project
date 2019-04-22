using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySoundOFf : MonoBehaviour
{
    public AudioSource enemySounds;

    void Update()
    {
        GameObject[] EnemiesLeft = GameObject.FindGameObjectsWithTag("Enemy");
        if (EnemiesLeft.Length == 0)
        {
            enemySounds.Pause();
        }

    }
}
