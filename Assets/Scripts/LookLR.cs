
using UnityEngine;

public class LookLR : MonoBehaviour
{
    [SerializeField] float lookSpeed = 10;

    void Update()
    {
        float rotation = Input.GetAxis("Mouse X");
        rotation *= lookSpeed;
        transform.Rotate(0, rotation, 0);
    }
}
