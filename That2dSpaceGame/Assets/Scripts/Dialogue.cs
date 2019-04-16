using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{

    private void Update()
    {
        ButtonPressed();
    }

    public string dialogue;
    public GameObject text;
    public GameObject textBackground;
    public GameObject Continue;
    bool buttonPressed = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject playerMovement = GameObject.Find("ThePlayer");
        playerMovement.GetComponent<Player_Action>().enabled = false;
        text.SetActive(true);
        textBackground.SetActive(true);
        StartCoroutine(TextType(dialogue));
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

    public void ButtonPressed()
    {

        if (Input.GetKeyDown("space"))
        {
            text.GetComponent<Text>().text = "";
            Continue.SetActive(false);
            text.SetActive(false);
            textBackground.SetActive(false);
            GameObject playerMovement = GameObject.Find("ThePlayer");
            playerMovement.GetComponent<Player_Action>().enabled = true;
            gameObject.SetActive(false);
        }

    }

}
