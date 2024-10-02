using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnCommand : ICommand
{

    //this is termed as CONCRETE COMMAND
    //the script inheriting from ICommand ensures that it implements Execute method which will have different implementations in different commands

    LightBulb _lightbulb;

    public TurnOnCommand(LightBulb lightBulb)   //we are making a constructor(it is called everytime class instantiate) so everytime a command is instantiated it has the refrence of Lightbulb
    {
      _lightbulb = lightBulb;           //this lines means whenever this class is instantiated the refrece its taking of lightBulb in costructor paremeter will be used as the _lightBulb variable that will be used in whole class
      //it means whenever a new TurnOnCommand object is created, it needs to be provided with a refrence to a LightBulb object
    }
    public void Execute()
    {
     _lightbulb.TurnOn();     //this is the actual command to turn on light bulb in LightBulb class
    }
}
