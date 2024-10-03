using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lerping : MonoBehaviour
{
    [SerializeField] private float speed = 0.5f;
    [SerializeField] private Vector3 goalPosition;
    [SerializeField] private Vector3 goalRotation;
    [SerializeField] private float goalScale;
    [SerializeField] private AnimationCurve curve;

    private float currentPosition;
    [SerializeField] private float targetPos;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            targetPos = targetPos == 0 ? 1 : 0;
        }

        currentPosition = Mathf.MoveTowards(currentPosition, targetPos , speed * Time.deltaTime);

        Debug.Log(currentPosition);


        transform.position = Vector3.Lerp(Vector3.zero, goalPosition, curve.Evaluate(currentPosition));
        transform.rotation = Quaternion.Lerp(Quaternion.Euler(Vector3.zero) , Quaternion.Euler(goalRotation) , curve.Evaluate(currentPosition));
        transform.localScale = Vector3.Lerp(Vector3.one , Vector3.one*goalScale , curve.Evaluate(Mathf.PingPong(currentPosition, 0.5f)*2f));
    }
}
