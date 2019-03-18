using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour

{
    /*[SerializeField] private string SceneName;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneName);
        }

   }*/

    public string prevScene = "";
    public string currentScene = "";

    public virtual void Start()
    {
        currentScene = SceneManager.GetActiveScene().name;

    }

    public void LoadScene(string sceneName)
    {
        GlobalControl.Instance.prevScene = currentScene;
        SceneManager.LoadScene(sceneName);
    }

}


