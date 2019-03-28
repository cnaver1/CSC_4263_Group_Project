using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomChange : MonoBehaviour
{
    public GameObject CurrentRoom;
    public GameObject NextRoom;
    public GameObject Door;
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        CurrentRoom.SetActive(false);
        NextRoom.SetActive(true);
      
    }

}
