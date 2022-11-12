using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rigidbody;
    public int moveSpeed = 10, rightLeftSpeed = 100;
    Vector3 lastMousePos, firstMousePos;

    void Awake()
    {
        rigidbody = this.gameObject.GetComponent<Rigidbody>();
    }


    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * moveSpeed;

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Input.mousePosition;
            pos.z = 10;
            firstMousePos = Camera.main.ScreenToWorldPoint(pos);

        }

        if (Input.GetMouseButton(0))
        {
            Vector3 pos = Input.mousePosition;
            pos.z = 10;
            lastMousePos = Camera.main.ScreenToWorldPoint(pos);
            Vector3 dif = lastMousePos - firstMousePos;
            transform.position += new Vector3(dif.x, 0, dif.z) * Time.deltaTime * rightLeftSpeed;
            firstMousePos = lastMousePos;
        }
    }
}
