using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldPos : SceneController
{

    public Transform ThePlayer;

    // Use this for initialization
    public override void Start()
    {
        base.Start();

        if (prevScene == "Interior")
        {
            ThePlayer.position = new Vector2(0f, 3f);
            Camera.main.transform.position = new Vector3(0f, 3f, -10f);
        }
    }

}