using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objective1 : MonoBehaviour
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

    public void Update()
    {
        Objective();
    }


    IEnumerator ObjectiveComplete()
    {
        ObjectiveText.GetComponent<Text>().text = "[x] Use WASD to move...";
        TextBackground.SetActive(false);
        DialogueText.SetActive(false);
        yield return new WaitForSeconds(3);
        OpenDoor.SetActive(true);
        ClosedDoor.SetActive(false);
        objnum++;
        ObjectiveHandler.ObjectiveNum = objnum;

    }


    public void Objective()
    {
        if (objnum == 1)
        {
            ObjectiveText.GetComponent<Text>().text = "[ ] Use WASD to move...";
            DialogueText.GetComponent<Text>().text = "Use the WASD keys to move the player!";
            if (Input.GetKey(KeyCode.W)) { up = true; }
            if (Input.GetKey(KeyCode.S)) { down = true; }
            if (Input.GetKey(KeyCode.A)) { left = true; }
            if (Input.GetKey(KeyCode.D)) { right = true; }
            if (up == true && down == true && left == true && right == true) { StartCoroutine(ObjectiveComplete()); }
        }

    }
}
