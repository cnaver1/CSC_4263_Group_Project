using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutScenes : MonoBehaviour
{
    string[] dialogue = new string[] { "Guards...Guards...", "What was that...", "Well Looks Like Its Time for Me to Escape!" };

  
    public GameObject text;
    public GameObject background;
    public GameObject Continue;
    public bool buttonOn;
    public int i = 0;
    void Start()
    {
    
        text.SetActive(true);
        background.SetActive(true);
        GameObject playerMovement = GameObject.Find("ThePlayer");
        playerMovement.GetComponent<Player_Action>().enabled = false;
        StartCoroutine(TextType(dialogue[i]));
        
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

    IEnumerator Wait()
    {
       yield return new WaitForSeconds(1000f);
    }

    void SpaceButton()
    {

        if (Input.GetKeyDown("space") && buttonOn == true)
        {
            i++;
            if (dialogue.Length > i )
            {
             
                text.GetComponent<Text>().text = "";
                StartCoroutine(TextType(dialogue[i]));
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
            }
        }
        

   
    }
}
