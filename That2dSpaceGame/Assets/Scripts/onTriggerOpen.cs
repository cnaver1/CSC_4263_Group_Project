using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onTriggerOpen : MonoBehaviour
{
    public GameObject doorOpen;
    public GameObject doorClosed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        doorOpen.SetActive(true);
        doorClosed.SetActive(false);
    }
}
