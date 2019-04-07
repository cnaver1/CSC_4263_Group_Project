using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponMechanics : MonoBehaviour
{
    string []char_dia =  new string[] { "WTF ARE THOSE?", "No matter.." , "Use the Arrow Keys to Attack"};

    public GameObject text;
    public GameObject background;
    public GameObject Continue;
    public GameObject ex;
    public bool buttonOn;
    public int i = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        ex.SetActive(true);
        EnemyMovement.speed = 0;
        text.SetActive(true);
        background.SetActive(true);
        GameObject playerMovement = GameObject.Find("ThePlayer");
        playerMovement.GetComponent<Player_Action>().enabled = false;
        StartCoroutine(TextType(char_dia[i]));

    }
  

    // Update is called once per frame
    void Update()
    {
       
        SpaceButton();
    }

    IEnumerator TextType(string x)
    {
        buttonOn = false;
        foreach (char letter in x.ToCharArray())
        {
            text.GetComponent<Text>().text += letter;
            yield return new WaitForSeconds(.07f);
        }
        buttonOn = true;
        Continue.SetActive(true);

        //Wait till space is pressed to proceed


    }


    void SpaceButton()
    {

        if (Input.GetKeyDown("space") && buttonOn == true)
        {
            i++;
            if (char_dia.Length > i)
            {

                text.GetComponent<Text>().text = "";
                StartCoroutine(TextType(char_dia[i]));
                Continue.SetActive(false);

            }

            else
            {
                text.GetComponent<Text>().text = "";
                GameObject playerMovement = GameObject.Find("ThePlayer");
                playerMovement.GetComponent<Player_Action>().enabled = true;
                text.SetActive(false);
                background.SetActive(false);
                Continue.SetActive(false);
                gameObject.SetActive(false);
                EnemyMovement.speed = 0.2f;
                ex.SetActive(false);
            }

        }



    }
}
