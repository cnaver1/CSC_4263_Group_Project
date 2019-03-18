using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ObjectiveHandler : MonoBehaviour
{
    public GameObject ObjectiveText;
    public GameObject DialogueText;
    public GameObject TextBackground;
    public GameObject ClosedDoor;
    public GameObject OpenDoor;
    public static bool ObjectiveStatus;
    public int objnum = 1;
    bool up;
    bool down;
    bool left;
    bool right;




    void Update()
    {
        Objective1();
        if(objnum == 2) { Objective2(); }
        
    }

    IEnumerator ObjectiveComplete()
    {
        ObjectiveText.GetComponent<Text>().text = "Objective Completet";
        TextBackground.SetActive(false);
        DialogueText.SetActive(false);
        yield return new WaitForSeconds(3);
        OpenDoor.SetActive(true);
        ClosedDoor.SetActive(false);


    }


    public void Objective1()
    {
        ObjectiveText.GetComponent<Text>().text = "Use WASD to move...";
        DialogueText.GetComponent<Text>().text = "Use the WASD keys to move the player!";
        if (Input.GetKey(KeyCode.W)) { up = true; }
        if (Input.GetKey(KeyCode.S)) { down = true; }
        if (Input.GetKey(KeyCode.A)) { left = true; }
        if (Input.GetKey(KeyCode.D)) { right = true; }
        if (up == true && down == true && left == true && right == true) { StartCoroutine(ObjectiveComplete()); objnum = 2; }

    }

    public void Objective2()
    {
        ObjectiveText.GetComponent<Text>().text = "Heal with the MedKit";
        DialogueText.GetComponent<Text>().text = "Use the healthkit to heal yourself";

    }


}