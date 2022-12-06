using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraSpeed = 6;
    public bool timeSc;

    void Update()
    {

        transform.position += Vector3.forward * cameraSpeed* Time.deltaTime ;

        timeSc = GameObject.FindWithTag("Player").GetComponent<PlayerController>().timeSc;

        if(timeSc == false)
        {
            cameraSpeed = 0;
        }

    }
}
