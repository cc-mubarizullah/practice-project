using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UserInput : MonoBehaviour
{ 
    //this script will act as an CLIENT

    //this script handles the input from user when he pressed space bar turnon function on light bulb script gets call

    GameObject lightBulb;
    LightBulb _lightBulb;

    LightSwitch _lightSwitch;

    void Start()
    {
        lightBulb = GameObject.Find("LightBulb");        //finding Go
        _lightBulb = lightBulb.GetComponent<LightBulb>();    //getting ref of lightbulb script
        


        ICommand turnOnCommand = new TurnOnCommand(_lightBulb);   //make a variable of ICommand named as turnOnCommand which make instance of the turnOnCommand class which takes the refrence of LightBulb class instance
        _lightSwitch = new LightSwitch(turnOnCommand);       //we are calling light switch which will control light on and off and pass off the turnOnCommand 
    }
    
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
        _lightSwitch.PowerOn();
        }
    }
}
