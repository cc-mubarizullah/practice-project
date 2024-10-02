using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FindByTag : MonoBehaviour
{

    //by using FindGameObjectWithTag(singular) we can find a specific object with a specific tag
    // by using FindGameObjectsWithTag(plural) we can find multiple gameobjects with the similar tag
    [SerializeField] private GameObject cubeToFind;
    string objectTag = "cubeTag";

    void Start()
    {
        cubeToFind = GameObject.FindGameObjectWithTag(objectTag);
        Debug.Log(cubeToFind.name);
    }
}
