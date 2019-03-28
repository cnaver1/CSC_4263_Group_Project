using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    //public float knockBack = 0.1f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    void OnTriggerEnter2D(Collider2D other)
    {
        //Touching Player
        if (other.gameObject.CompareTag("Player"))
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
        }
    }*/
}
