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
        
    }


    void Update()
    {
        years = Player.GetComponent<PlayerController>().years;
        people = Player.GetComponent<PlayerController>().people;

        Force = (years / 50) * 2;
        Text.text = barrierForce.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Clone")
        {
            barrierForce = barrierForce - Force;
            if (barrierForce <= 0)
            {
                Destroy(this.gameObject);
                Destroy(other.gameObject);
            }
        }
    }
}
