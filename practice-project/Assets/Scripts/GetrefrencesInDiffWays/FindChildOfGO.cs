using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FindChildOfGO : MonoBehaviour
{
    private GameObject childGameObject;

    void Start()
    {
        childGameObject = transform.GetChild(0).gameObject;  // by using this method we can access the children of a gameobject this script attach to 
        Debug.Log(childGameObject.name);
    }
}
//notice GetChild() method work with transform not gameobject with which script is attached