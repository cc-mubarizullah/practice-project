using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Pool;

public class CubeSpawner : MonoBehaviour
{
    ObjectPooler objectPooler;

    void Start()
    {
        objectPooler = ObjectPooler.instace;
    }
void FixedUpdate()
{
        objectPooler.SpawnFromPool("Cube", transform.position, Quaternion.identity);
}
}
