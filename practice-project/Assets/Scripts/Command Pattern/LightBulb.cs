using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LightBulb : MonoBehaviour
{

    //this script is attached to lightbulb and this script only have function to TurnOn




    GameObject child;
    void Start()
    {
        child = transform.GetChild(0).gameObject;
    }
    public void TurnOn()
    {
        child.SetActive(true);
    }
}
