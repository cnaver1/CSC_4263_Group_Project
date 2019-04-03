using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class autoText : MonoBehaviour
{
    string myString = " Guards...Guards, what!";
   

   public GameObject myText;
    public GameObject Continue;
    void Start()
    {
        StartCoroutine("AutoType");
     
        myText.GetComponent<Text>().text = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator AutoType()
    {
        foreach (char letter in myString.ToCharArray()) {

            myText.GetComponent<Text>().text += letter;
            yield return new WaitForSeconds(.1f);
        }
        Continue.SetActive(true);
    }

}
