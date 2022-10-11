using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //para que la cámara siga
    [HideInInspector]
    public Vector3 targetPos;
    float smoothMove = 1f;
    private void Start() {
        targetPos = transform.position;
    }
    private void Update() {
        transform.position = Vector3.Lerp(transform.position, targetPos, smoothMove*Time.deltaTime);
    }
}
