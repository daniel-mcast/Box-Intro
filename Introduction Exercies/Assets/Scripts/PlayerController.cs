using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //the speed at which the player moves at.
    //explain how with a public variable you are able to see it in the inspector and not with private.
    //explain Serializefield ? and explain why it is good practice to keep game balancing variables private.
    //explain the proper naming conventions for variables.
    [SerializeField]
    public int speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        //Point 1 Use to explain the Start method position the player in 1.5,1.5,1.5
        //Pseudo 1. The player position is reset to 0 on all three axis at the start of the game.
        //Breakdown the use of vector 3
        //Vector3(float x,float y, floatz)
        //Below statement. access the transform component.access position = then change them to the new co-ordinates.(x = 0,y = 0,z = 0)
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

        //Point 3 Introduce the concept of if statements with Inputs using arrow keys.
        //Pseudo 3 When the right arrow is pressed the player moves to the right.
        //if the input component.recieves key push.with the key.right arrow then run the code below
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Point 2 Show the difference between speed with Time and without
            //Pseudo 2. The player moves right on the x axis.(N.B the player moves on the positive values)
            //Use the same explanation to explain vector 3 as you did for lv 5s
            //Translate(float x,float y,float z)
            //1 transform.Translate(1,0,0);
            //introduce variable concept explain public(visible in inspector and reasons to do so, private variable why and explain SerializeField)
            //2 transform.Translate(speed,0,0)
            //Explain that atm the speed is being multiplied by the framerate of the update method
            //add Time.deltaTime and explain that this is done so that the movement is always constant and it is dependent on time not fps
            //thisobject.access the transform component.Translate Method(x = speed * realTime,0,0);
            transform.Translate(speed * Time.deltaTime,0,0);
            //Point 6 Point out step by step what the code is doing.(Show link for unity answers https://answers.unity.com/questions/984554/change-color-of-a-gameobject-when-it-collisions-c.html)
            //Pseudo 6 The player colour is changed to blue when it moves to the right.
            //takes the current gameobject.find renderer component.find the material.the color property = takes the colour and give it a value of blue (R,G,B,A)(0,0,1,1)
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        //Point 4 Introduce the concept of multiple if statements in the same script and explain the difference between if/elseif and else
        //Pseudo 4 When the left arrow is pressed the player moves to the left.
        //Challenge them to create the following piece on their own give them 10 mins to do so.
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Point 5 Point out that because we want the player to move to the left we use the negative of the variable speed.
            //Pseudo 5 The player moves left on the x axis.(N.B the player moves on the negative values)
            transform.Translate(-speed * Time.deltaTime,0,0);
            //Point 7 Point out step by step what the code is doing.
            //Pseudo 7 The player colour is changed to blue when it moves to the right.
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        
        

    }
}
