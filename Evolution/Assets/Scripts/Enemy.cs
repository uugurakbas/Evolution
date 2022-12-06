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
        if (collision.gameObject.tag == "ClonePlayer")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Clone")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
