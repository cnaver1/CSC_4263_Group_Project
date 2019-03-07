using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WASD_Objective : MonoBehaviour
{
    public GameObject Open_Door;
    public GameObject Closed_Door;
    public bool up = false;
    public bool down = false;
    public bool left = false;
    public bool right = false;
    public GameObject TextBox;
    public GameObject Objective;
    public GameObject TextBackground;


  
    void Update()
    {
        TextBox.GetComponent<Text>().text = "Use The Arrows Keys to Move...";
        Objective.GetComponent<Text>().text = "[ ] use the arrow keys to move";
        if (Input.GetKey(KeyCode.UpArrow))
        {
            up = true;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            down = true;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            left = true;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            right = true;
        }

        if (up == true & down == true & right == true & left == true)
        {
            StartCoroutine(ObjectiveComplete());
           
        }
    }
    IEnumerator ObjectiveComplete()
    {
        Objective.GetComponent<Text>().text = "[x] use the arrow keys to move";
        TextBox.SetActive(false);
        TextBackground.SetActive(false);
        yield return new WaitForSeconds(3);
        Objective.GetComponent<Text>().text = "[ ] proceed to the next room";
        Open_Door.SetActive(true);
        Closed_Door.SetActive(false);
    }
}
