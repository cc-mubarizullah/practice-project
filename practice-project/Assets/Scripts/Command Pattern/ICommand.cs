using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICommand 
{
   //I is added before writing interfaces
   //it can also be termed as ABSTRACT COMMAND in command pattern
   //this is an interface which provides the compulsory methods for all the commands to implement in their own way
   //currently it is holding only one method


   void Execute();
}
