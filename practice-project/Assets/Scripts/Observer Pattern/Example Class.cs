using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleClass 
{
   public delegate void DoSomeThing(int num);        //this is the syntax of writing delegates. Delegates are the type of method 
   //which do not have any body. the delegates hold the refrernce of the method. It allows us to invoke method through delegate even 
   // if we dont have direct refrence to the object

   public DoSomeThing something;          //if we want to use a delgate we have to make instance of it. In this case Something hold the instance.

   public ExampleClass()
   {
    something = Function1;
    something(123);
   }

   void Function1(int num)
   {
    Console.WriteLine("Function one is called with value :" + num);
   }
}
