using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{

    public int years = 0, yearsPlus, people = 0, peoplePlus;

    [HideInInspector] public GameObject Clone;
    [HideInInspector] public bool  TriggerActive = false;
    [HideInInspector] public Rigidbody rb;


    void Awake()
    {
        rb = GameObject.FindWithTag("Player").GetComponent<Rigidbody>();

    }

    
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "TriggerYear")
        {
           if(TriggerActive == false)
            {
                yearsPlus = other.GetComponent<Years_People>().YearsPlus;
                Destroy(other.gameObject);
                years = yearsPlus + years;
                Debug.Log(years + "Yýl");
                StartCoroutine(TrActive());
            }

        }
        if (other.gameObject.tag == "TriggerPeople")
        {
            if(TriggerActive == false)
            {
                peoplePlus = other.GetComponent<Years_People>().PeoplePlus;
                Destroy(other.gameObject);
                people = peoplePlus + people;
                gameObject.GetComponent<PlayerClone>().Clone();
                Debug.Log(people+"Kiþi");
                StartCoroutine(TrActive());
            }


        }

    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "BarierrsPlane")
        {
            Debug.Log("geldi");
            Destroy(GameObject.FindWithTag("ClonePlayer"));
        }
    }

    public IEnumerator TrActive()
    {
        TriggerActive = true;
        yield return new WaitForSeconds(0.5f);
        TriggerActive = false;

    }


}
