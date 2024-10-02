using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{ 

    //through drag and drop method we can get refrence of only those objects which are present at compile time
    // this method cannot be used for the objects which are created at runtime.


    [SerializeField] private GameObject cube;    //we have to drag and drop the object in the inspector
    [SerializeField] private Rigidbody cubeRb;   //we will drag and drop the gameobject its component will be automatically added
    
    void Start()
    {
        Debug.Log(cube.name);
        Debug.Log(cubeRb.mass);
    }

    
}
