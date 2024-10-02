using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RefOfGoByObj : MonoBehaviour
{
    //finding a unique component
   [SerializeField] private GameObject objToFind;
   
   void Start()
   {
    objToFind = FindAnyObjectByType<FindByName>().gameObject;  //in this way we can find a gameObject which has a specific component
                                                               //by using plural of it we can get access of all the specific components in scene as well as their gameobject
    Debug.Log(objToFind.name);
   }
   // the gameobject should be active whoes refrence we are taking
}
