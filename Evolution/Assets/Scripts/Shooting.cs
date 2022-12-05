using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using System;

public class Shooting : MonoBehaviour   
{

    public GameObject RockPrefab;
    public Transform CloneTransform;
    [HideInInspector]
    public GameObject Clone;
    public bool active = true;

    private void Start()
    {
        StartCoroutine(RockFire());
    }
    public IEnumerator RockFire()
    {

        while (active == true)
        {

            Clone = Instantiate(RockPrefab, CloneTransform.position, Quaternion.identity) as GameObject;
            Clone.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 100), ForceMode.Impulse);
            yield return new WaitForSeconds(0.7f);
            Destroy(Clone);
            yield return new WaitForSeconds(0.35f);
        }


    }
}
