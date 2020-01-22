using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour

    
{
    public Vector3 startposition; 

    void Awake()
    {
        startposition = transform.position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            // Move the object to the same position as the parent:
            transform.position = startposition;

        }
    }
}
    
