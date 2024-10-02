using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FindByName : MonoBehaviour
{

    //by this method we can find any gameobject that is present in hirarechy
    // the Find() method searches the entire hirarechy and compare the name given in its paremeter and returns it
   public GameObject cubeToFind;
   string objectName = "cube";                   //its a good practice to make a variable of string, so it will become easy to change them after if we change objects name 

   void Start()
   {
    cubeToFind = GameObject.Find(objectName);     //first we are making a variable of type gameobject and then we are assigning the refrence of the gameobject present in the hirerachy
    Debug.Log(cubeToFind.name);
   }
}
  //note this Find() method cannot find prefabs present in project window
  