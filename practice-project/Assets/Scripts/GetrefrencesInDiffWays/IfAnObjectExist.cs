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
        if(audioGo.TryGetComponent<AudioSource>(out audioSource))
        {
            Debug.Log("audioSourceFound");
        }
        else
        Debug.Log("audioComponentnotofund");

    }
}
