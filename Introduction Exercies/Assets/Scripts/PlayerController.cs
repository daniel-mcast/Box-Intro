using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //the player moves with this speed.
    private int _speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        //Point 1 Use to explain the Start method
        //Pseudo 1. The player position is reset to 0 on all three axis at the start of the game.
        this.transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Pseudo 2. The player moves up on the y axis.
        this.transform.Translate(0, _speed * Time.deltatime, 0);
    }
}
