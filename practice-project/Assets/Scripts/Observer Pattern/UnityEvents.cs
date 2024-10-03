using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
public class UnityEvents : MonoBehaviour
{
    [SerializeField] private UnityEvent unityEvent;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("base"))
        {
            unityEvent?.Invoke();
        }
    }
}
