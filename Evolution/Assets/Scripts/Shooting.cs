using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class Shooting : MonoBehaviour
{
    public int Force,years,people,barrierForce;
    [HideInInspector] public GameObject Player;
    public TextMeshPro Text;

    void Awake()
    {
        Player = GameObject.FindWithTag("Player");
        Text.text = barrierForce.ToString();
    }

   
    void Update()
    {
        years = Player.GetComponent<PlayerController>().years;
        people = Player.GetComponent<PlayerController>().people;

        Force = (years / 50) * 2;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Clone")
        {
            barrierForce = barrierForce - Force;
            if(barrierForce == 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
