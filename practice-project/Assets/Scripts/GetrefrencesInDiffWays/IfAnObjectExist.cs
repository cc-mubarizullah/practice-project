using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class IfAnObjectExist : MonoBehaviour
{
    [SerializeField] GameObject audioGo;
    AudioSource audioSource;

    void Start()
    {
        audioGo = GameObject.Find("auidoGameobject");
        Debug.Log(audioGo.name);
        if(audioGo.TryGetComponent<AudioSource>(out audioSource))  // this TryGetComponent returns true if the component is present we also have to save its out in variable
        {
            Debug.Log("audioSourceFound");
        }
        else
        Debug.Log("audioComponentnotofund");

    }
}
