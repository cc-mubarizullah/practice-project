using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch
{
  ICommand _onCommand;

  public LightSwitch(ICommand onCommand)   //made a constructor which takes the paremeter of type ICommand interface 
  {
    _onCommand = onCommand;  // assigning it to member of the class
  }

  public void TogglePower()
  {
    _onCommand.Execute();    //here we make a public method which will when called execute the command.
  }
}
