using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClone : MonoBehaviour
{
    public int peoplePlus,people,lenght;
    public Transform[] PlayerCloneTransform;
    public GameObject Playerclone;
    private void Update()
    {

        people = GameObject.FindWithTag("Player").GetComponent<PlayerController>().people;
    }
    public void ClonePlus()
    {
        peoplePlus = GameObject.FindWithTag("Player").GetComponent<PlayerController>().peoplePlus;
        Debug.Log("x");
        if (peoplePlus > 0)
        {          
            for (int i = people; i < (people+peoplePlus); i++)
            {               
                Instantiate(Playerclone, PlayerCloneTransform[i].position , Quaternion.identity);
                Debug.Log(i);

            }

        }
    }
    public void CloneMultiplied()
    {
        peoplePlus = GameObject.FindWithTag("Player").GetComponent<PlayerController>().peoplePlus;
        if (peoplePlus > 0)
        {


            if (people == 0)
            {
                lenght = 1* peoplePlus;
            }
            else if(people > 0)
            {
                lenght = people * peoplePlus;
            }

            for (int i = people; i < lenght; i++)
            {
                Instantiate(Playerclone, PlayerCloneTransform[i].position, Quaternion.identity);
            }

        }
    }
}
