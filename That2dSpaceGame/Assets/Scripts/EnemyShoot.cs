﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject Prefab;
    public float fireRate;
    public float nextFire;

    void Start()
    {
        nextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        CheckFire();
    }

    void CheckFire()
    {
        if (Time.time > nextFire)
        {
            GameObject bullet = Instantiate(Prefab, transform.position, Quaternion.identity);
           
            nextFire = Time.time + fireRate;
        }


    }
}