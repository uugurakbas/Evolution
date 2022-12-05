using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Barierr : MonoBehaviour
{
    public int Force, years, people, barrierForce;
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

        Force = (years / 25);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Clone")
        {
            barrierForce = barrierForce - Force;
            if (barrierForce <= 0)
            {
                Destroy(this.gameObject);
                Destroy(collision.gameObject);
            }
        }
    }
}
