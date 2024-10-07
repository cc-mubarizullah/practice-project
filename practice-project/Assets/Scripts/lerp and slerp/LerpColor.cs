using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class LerpColor : MonoBehaviour
{
   [SerializeField] private Color firstColor;
   [SerializeField] private Color secondColor;
   [SerializeField] private Color outputColor;
   [SerializeField] [Range(0,1f)] private float t;


   void Update()
   {
    outputColor = Color.Lerp(firstColor, secondColor , t);
   }
}
