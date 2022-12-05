using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClone : MonoBehaviour
{
    public int peoplePlus;
    public Transform[] PlayerCloneTransform;
    public GameObject Playerclone;
    private void Update()
    {
        
    }
    public void Clone()
    {
        peoplePlus = GameObject.FindWithTag("Player").GetComponent<PlayerController>().people;
        if (peoplePlus > 0)
        {
            for (int i = 0; i < peoplePlus; i++)
            {               
                Instantiate(Playerclone, PlayerCloneTransform[i].position , Quaternion.identity);
            }

        }
    }
}
