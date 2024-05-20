using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorLock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        if (Cursor.visible == false)
        {
            
            Cursor.visible = true;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
