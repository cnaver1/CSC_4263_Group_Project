using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objective2 : MonoBehaviour
{
    public GameObject ObjectiveText;
    public GameObject DialogueText;
    public GameObject TextBackground;
    public GameObject ClosedDoor;
    public GameObject OpenDoor;
    public GameObject HealthItem;
    public static bool ObjectiveStatus;
    public int objnum;
   
    
   

    void Update()
    {
        objnum = ObjectiveHandler.ObjectiveNum;
        Objective();
    }

    IEnumerator ObjectiveComplete()
    {
        ObjectiveText.GetComponent<Text>().text = "[x] Heal with the MedKit";
        TextBackground.SetActive(false);
        DialogueText.SetActive(false);
        yield return new WaitForSeconds(3);
        OpenDoor.SetActive(true);
        ClosedDoor.SetActive(false);
        objnum++;

    }


    public void Objective()
    {
        if (objnum == 2)
        {
            TextBackground.SetActive(true);
            DialogueText.SetActive(true);
            ObjectiveText.GetComponent<Text>().text = "[ ] Heal with the MedKit";
            DialogueText.GetComponent<Text>().text = "Walk over the health-kit to heal yourself";

           
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(HealthItem.GetComponent<BoxCollider2D>())
        {
            StartCoroutine(ObjectiveComplete());
        }
    }

}

