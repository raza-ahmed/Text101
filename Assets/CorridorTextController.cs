using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CorridorTextController : MonoBehaviour
{
    public Text text;
    private enum States {corridor_0, corridor_1, corridor_2, corridor_3,
                        stairs_0, stairs_1, stairs_2, floor, closet_door,
                        in_closet, courtyard};

    private States myState;

    // Start is called before the first frame update
    void Start()
    {
        myState = States.corridor_0;
    }

    // Update is called once per frame
    void Update()
    {
        if (myState == States.corridor_0)           {State_corridor_0();}
        else if (myState == States.corridor_1)      {State_corridor_1();}
        else if (myState == States.corridor_2)      {State_corridor_2();}
        else if (myState == States.corridor_3)      {State_corridor_3();}
        else if (myState == States.stairs_0)        {State_stairs_0();}
        else if (myState == States.stairs_1)        {State_stairs_1();}
        else if (myState == States.stairs_2)        {State_stairs_2();}
        else if (myState == States.floor)           {State_floor();}
        else if (myState == States.closet_door)     {State_closet_door();}
        else if (myState == States.in_closet)       {State_in_closet();}
        else if (myState == States.courtyard)       {State_courtyard();}
    }

    void State_corridor_0()
    {
        text.text = "You are in a corridor and this is the only chance for you "+
                    "to escape. Make the right choices and live a free life.\n\n"+
                    "Press Q for Stairs, W for Floor, E for Closet Door and "+
                    "return to go back";
             if (Input.GetKeyDown(KeyCode.Q))       {myState = States.stairs_0;}
        else if (Input.GetKeyDown(KeyCode.W))       {myState = States.floor;}
        else if (Input.GetKeyDown(KeyCode.E))       {myState = States.closet_door;}
    }
    void State_stairs_0()
    {
        text.text = "Oh No! Stairs will take you to the guards office\n\n" +
                    "Press return to go back";
        if (Input.GetKeyDown(KeyCode.Return))       {myState = States.corridor_0;}
    }
    void State_closet_door()
    {
        text.text = "Nothing on the closet door\n\n" +
                    "Press return to go back";

         if (Input.GetKeyDown(KeyCode.Return))      {myState = States.corridor_0; }
    }
    void State_floor()
    {
        text.text = "There is a hairclip on the floor\n\n" +
                    "Press R to pick the hairclip and return to go back";

             if (Input.GetKeyDown(KeyCode.R))       {myState = States.corridor_1; }
        else if (Input.GetKeyDown(KeyCode.Return))  {myState = States.corridor_0; }
    }
    void State_corridor_1()
    {
        text.text = "This floor guided me to another corridor. "+
                    "I got two options here another closet and a staircase" +
                    "I can try opeining closet using the hair clip or take stairs\n\n"+
                    "Press A to open the close, S for stairs or return to go back";

             if (Input.GetKeyDown(KeyCode.A))       {myState = States.in_closet; }
        else if (Input.GetKeyDown(KeyCode.S))       {myState = States.stairs_1; }
        else if (Input.GetKeyDown(KeyCode.Return))  {myState = States.floor; }
    }

    void State_stairs_1()
    {
        text.text = "Oh No! Stairs will take you to the another prison cell\n\n" +
                    "Press return to go back";
        if (Input.GetKeyDown(KeyCode.Return))       {myState = States.corridor_0; }
    }
    void State_in_closet()
    {
        text.text = "Great! Noboady will identify me in this Cleaners dress" +
                    "This is the best fit dresss I found on the closet"+
                    "Now I just need to walk through one of these two corridors \n\n" +
                    "Press P for Corridor 3 and return for Corridor 2";

             if (Input.GetKeyDown(KeyCode.Z))       {myState = States.corridor_2;}
        else if (Input.GetKeyDown(KeyCode.Return))  {myState = States.corridor_3; }
    }

    void State_corridor_2()
    {
        text.text = "All I can see is just a stair, Let's try that\n\n" +
                    "Press M to take Stairs";
        if (Input.GetKeyDown(KeyCode.M))            {myState = States.stairs_2;}
    }
    void State_stairs_2()
    {
        text.text = "Holy Crap! This stair has a CCTV camera I am caught"+
                    "Press Return to go back and space to start the game again\n\n";

             if (Input.GetKeyDown(KeyCode.Return))   {myState = States.corridor_2;}
        else if (Input.GetKeyDown(KeyCode.Space))    {myState = States.corridor_0;}
    }
    void State_corridor_3()
    {
        text.text = "I can see the courtyard that seems to be the main exit " +
                    "or I should undress and get my prison dress back?\n\n" +
                    "Press F to escape through prison, U to undress and return";

             if (Input.GetKeyDown(KeyCode.F))       {myState = States.courtyard;}
        else if (Input.GetKeyDown(KeyCode.U))       {myState = States.in_closet;}
    }
    void State_courtyard()
    {
        text.text = "Yes I did it, I finally escaped the prison\n\n" +
                    "Press Space to Start again";

        if (Input.GetKeyDown(KeyCode.Space))        {myState = States.corridor_0;}
    }
}
