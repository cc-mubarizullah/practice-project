using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "ScriptableObject1",menuName ="ScriptableObjects/Properties")]
public class ScripObj : ScriptableObject
{
    public string objectName;
    public string descriptionOfCard;
    public int health;
    public float manaCost;
    public Sprite sprite;
    public void Print()
    {
        Debug.Log("the object name is :" + objectName + "the health is :"+ health);
    }
}
