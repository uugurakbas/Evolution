using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using System;

public class Shooting : MonoBehaviour   
{

    public GameObject[] RockPrefab;
    public Transform CloneTransform;
    public bool timeSc, active = true;
    [HideInInspector]
    public GameObject Clone;

    public int i,years;

    private void Start()
    {
        StartCoroutine(RockFire());
    }
    private void Update()
    {
        timeSc = GameObject.FindWithTag("Player").GetComponent<PlayerController>().timeSc;

        if(timeSc == false)
        {
            active = false;
        }

    }
    public IEnumerator RockFire()
    {

        while (active == true)
        {
            years = GameObject.FindWithTag("Player").GetComponent<PlayerController>().years;
            i = years / 100;
            Clone = Instantiate(RockPrefab[i], CloneTransform.position, Quaternion.identity) as GameObject;
            Clone.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 100), ForceMode.Impulse);
            yield return new WaitForSeconds(0.7f);
            Destroy(Clone);
            yield return new WaitForSeconds(0.3f);
        }


    }
}
