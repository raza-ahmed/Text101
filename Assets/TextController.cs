using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextController : MonoBehaviour
{
    public Text text;
    private  enum States {bottom, horse, helicopter, person, helipad, pond,
                          forest, location};
    private States myState;

    // Start is called before the fir st frame update
    void Start()
    {
        myState = States.bottom;
    }

    // Update is called once per frame
    void Update()
    {
        print(myState);
        if (myState == States.bottom)               {State_bottom();}
        else if (myState == States.horse)           {State_horse();}
        else if (myState == States.helicopter)      {State_helicopter();}
        else if (myState == States.person)          {State_person();}
        else if (myState == States.helipad)         {State_helipad();}
        else if (myState == States.pond)            {State_pond();}
        else if (myState == States.forest)          {State_forest();}
        else if (myState == States.location)        {State_location();}
    }
    void State_bottom()
    {
        myState = States.bottom;
        text.text = "You are at the bottom of a mountain and you want to climb it. " +
                        "You have a mountain horse, a helicopter and a person.\n\n" +
                        "Press M to ride the horse, H to enter in the helicopter "+
                        "and P for asking a person";

        if (Input.GetKeyDown(KeyCode.M))            {State_horse();}
        else if (Input.GetKeyDown(KeyCode.H))       {State_helicopter();}
        else if (Input.GetKeyDown(KeyCode.P)) { State_person(); }
        
    }
    void State_horse()
    {
        myState = States.horse;
        text.text = "Horse gets tired and its freezing cold at the peak. " +
                    "No easy access of the grass for the horsy\n\n" +
                    "Press Return to go back";
        if (Input.GetKeyDown(KeyCode.Return))       {myState = States.bottom;}
    }
    void State_person()
    {
        myState = States.person;
        text.text = "Two people can easily be caught. " +
                    "There are many spies who may broadcast your escape!\n\n" +
                    "Press Return to go back";
        if (Input.GetKeyDown(KeyCode.Return))       {myState = States.bottom;}
    }
    void State_helicopter()
    {
        myState = States.helicopter;
        text.text = "Good choice! Pilot is skilled in flying in the moutains. " +
                    "A pro prison escaper.\n\n"+
                    "Press D for Pond, F for Forest, A to land on Helipad and " +
                    "return to go back";

        if (Input.GetKeyDown(KeyCode.D))            {myState = States.pond;}
        else if (Input.GetKeyDown(KeyCode.F))       {myState = States.forest;}
        else if (Input.GetKeyDown(KeyCode.A))       {myState = States.helipad;}
        else if (Input.GetKeyDown(KeyCode.Return))  {myState = States.bottom;}
    }
    void State_pond()
    {
        myState = States.pond;
        text.text = "Helicopter would drown on the pond! " +
                    "Find a better landing Place.\n\n" +
                    "Press Return to go back";
        if (Input.GetKeyDown(KeyCode.Return))       {myState = States.helicopter;}
    }
    void State_forest()
    {
        myState = States.forest;
        text.text = "This forest is very dense. " +
                    "It might damage the helicopter.\n\n" +
                    "Press Return to go back";
        if (Input.GetKeyDown(KeyCode.Return))       {myState = States.helicopter;}
    }

    void State_helipad()
    {
        myState = States.helipad;
        text.text = "Congratulations" +
                    "You Have reached an easy escape route.\n\n" +
                    "Press L and go to your location";

        if (Input.GetKeyDown(KeyCode.L))            {myState = States.location;}
    }
    void State_location()
    {
        myState = States.location;
        text.text = "Congratulations!\n\n" +
                    "Press Space to play again";

        if (Input.GetKeyDown(KeyCode.Space))        {myState = States.bottom;}
    }
}
