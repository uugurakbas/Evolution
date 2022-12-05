using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public int moveSpeed = 10, rightLeftSpeed = 100;
    Vector3 lastMousePos, firstMousePos;
    public float bounds = 5;

    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -bounds, bounds), transform.position.y, transform.position.z);
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
            transform.position += new Vector3(dif.x, 0, 0) * Time.deltaTime * rightLeftSpeed;
            firstMousePos = lastMousePos;
        }
    }
}
