using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarRotation : MonoBehaviour
{
    private Camera cam;

    private void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        Vector3 positionVector = cam.transform.position;
        positionVector.y = transform.position.y;

        transform.LookAt(positionVector);
    }
}