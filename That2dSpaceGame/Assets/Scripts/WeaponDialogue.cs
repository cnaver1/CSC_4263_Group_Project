using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponDialogue : MonoBehaviour
{ 
     string dialogue =   "My blades! Just what I need to Escape..." ;

    public GameObject text;
    public GameObject background;
    public GameObject Continue;
    public GameObject FakeWeapon;
    public GameObject Arrow;
    public GameObject DoorClosed;
    public GameObject DoorOpened;

    public bool buttonPressed;
    public static bool equipWeapon;
    public int i = 0;

   void OnTriggerEnter2D(Collider2D other)
    {

        DoorClosed.SetActive(false);
        DoorOpened.SetActive(true);
    FakeWeapon.SetActive(false);
  
    Arrow.SetActive(false);
    text.SetActive(true);
    background.SetActive(true);
    GameObject playerMovement = GameObject.Find("ThePlayer");
    playerMovement.GetComponent<Player_Action>().enabled = false;
    StartCoroutine(TextType(dialogue));
        equipWeapon = true;
    
}

// Update is called once per frame
void Update()
{
    SpaceButton();
}

IEnumerator TextType(string x)
{
    buttonPressed = false;
    foreach (char letter in x.ToCharArray())
    {
        text.GetComponent<Text>().text += letter;
        yield return new WaitForSeconds(.07f);
    }

        Continue.SetActive(true);
}


void SpaceButton()
{

    if (Input.GetKeyDown("space"))
    {
      
    

            text.GetComponent<Text>().text = "";
            Continue.SetActive(false);
            GameObject playerMovement = GameObject.Find("ThePlayer");
            playerMovement.GetComponent<Player_Action>().enabled = true;
            text.SetActive(false);
            background.SetActive(false);
            Continue.SetActive(false);
                gameObject.SetActive(false);
            
            }
    }



}

