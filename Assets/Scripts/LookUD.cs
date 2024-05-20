
using UnityEngine;

public class LookUD : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 5;
    [SerializeField] float maxUpRotation = -10;
    [SerializeField] float maxDownRotation = 40;

    void Update()
    {
        float oldXRotation = transform.rotation.eulerAngles.x;
        if (oldXRotation > 180)
            oldXRotation -= 360;

        float rotAmount = -Input.GetAxis("Mouse Y") * rotationSpeed;
        float newXRotation = oldXRotation + rotAmount;

        newXRotation = Mathf.Clamp(newXRotation, maxUpRotation, maxDownRotation);

        transform.Rotate(newXRotation - oldXRotation, 0, 0);
    }
}
