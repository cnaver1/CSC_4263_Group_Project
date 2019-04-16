using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalControl : MonoBehaviour
{
    public static GlobalControl Instance;
    public float hp;
    public float mana;
    public float xp;
    public string currentScene;
    public string prevScene;
    public string doorID;
    public int objnum;
    [Header("Unity")]
    public Image healthBar;

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
}


