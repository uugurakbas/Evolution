using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ClonePlayer" || collision.gameObject.tag == "Clone")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }


    }
}
