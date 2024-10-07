using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lerp : MonoBehaviour
{
   [SerializeField] private Transform a;   // so this the transform of the starting object 
   [SerializeField] private Transform b;  //target object
   [SerializeField] private float t;      // this determines whether the positon will be betwewn 0 and 1



   void Update()
   {
    transform.position = Vector3.Lerp(a.position, b.position, t);
   }
}
