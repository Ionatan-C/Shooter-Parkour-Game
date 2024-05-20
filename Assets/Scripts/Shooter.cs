using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    Camera cam;

    void Start()
    {
        cam = Camera.main;

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }

    }

    void Shoot()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {

            GameObject go = hit.collider.gameObject;

            if (go.CompareTag("Enemy"))
            {
                EnemyHealth health = go.GetComponent<EnemyHealth>();
                health.mainHealth = health.mainHealth - 50;

            }
        }
    }

  
}
