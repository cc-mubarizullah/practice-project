using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CubeForPooling : MonoBehaviour
{
    float upForce = 1f;
    float sideForce = .1f;

    void Start()
    {
        float xForce = Random.Range(-sideForce, sideForce);
        float yForce = Random.Range(upForce/2 , upForce);
        float zforce = Random.Range(-sideForce, sideForce);

        Vector3 force = new Vector3(xForce, yForce, zforce);
        GetComponent<Rigidbody>().velocity = force;
    }

}
