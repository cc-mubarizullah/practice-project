using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LightBulb : MonoBehaviour
{

    //this script is attached to lightbulb and this script only have function to TurnOn

    bool isPowerOn = false;


    GameObject child;
    void Start()
    {
        child = transform.GetChild(0).gameObject;
    }
    public void TogglePower()
    {
        if (isPowerOn == false)
        {
            child.SetActive(true);
            isPowerOn = true;
        }
        else
        {
            child.SetActive(false);
            isPowerOn = false;
        }
    }

}
