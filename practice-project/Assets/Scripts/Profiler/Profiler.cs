using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Profiler : MonoBehaviour
{
    [SerializeField] GameObject obj;
   
    void Update()
    {
        Instantiate(obj,transform.position, Quaternion.identity);
        Debug.Log("obj is created");
    }
}
