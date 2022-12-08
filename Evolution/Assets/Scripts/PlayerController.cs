using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class PlayerController : MonoBehaviour
{

    public int years = 0, yearsPlus, people = 0, peoplePlus,speed;
    public TextMeshPro yearsText;
    public bool multiplied = false;

    [HideInInspector] public GameObject Clone;
    [HideInInspector] public bool  TriggerActive = false, timeSc = true, GameOver = false, Complated = false ;
    [HideInInspector] public Rigidbody rb;



    void Awake()
    {
        rb = GameObject.FindWithTag("Player").GetComponent<Rigidbody>();

    }
    private void Update()
    {
        yearsText.text = years.ToString();
    }



    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            timeSc = false;
            GameOver = true;
        }
        if(collision.gameObject.tag == "Barierr")
        {
            timeSc = false;
            Complated = true;

        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "TriggerYear")
        {
           if(TriggerActive == false)
            {
                multiplied = other.GetComponent<Years_People>().multiplied;
                yearsPlus = other.GetComponent<Years_People>().YearsPlus;
                Destroy(other.gameObject);
                if(multiplied)
                {
                    years = yearsPlus * years;
                }
                else
                {
                    years = yearsPlus + years;
                }

                Debug.Log(years + "Yýl");
                StartCoroutine(TrActive());
            }

        }
        if (other.gameObject.tag == "TriggerPeople")
        {
            if(TriggerActive == false)
            {
                multiplied = other.GetComponent<Years_People>().multiplied;
                peoplePlus = other.GetComponent<Years_People>().PeoplePlus;
                Destroy(other.gameObject);
                if (multiplied)
                {
                    gameObject.GetComponent<PlayerClone>().CloneMultiplied();
                    if (people == 0) 
                    {
                        people = peoplePlus * 1;
                    }
                    else
                    {
                        people = peoplePlus * people;
                    }


                }
                else
                {
                    gameObject.GetComponent<PlayerClone>().ClonePlus();
                    people = peoplePlus + people;

                }

                Debug.Log(people+"Kiþi");
                StartCoroutine(TrActive());
            }


        }

    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "BarierrsPlane")
        {
            Destroy(GameObject.FindWithTag("ClonePlayer"));
            Destroy(GameObject.FindWithTag("Clone"));
        }
    }

    public IEnumerator TrActive()
    {
        TriggerActive = true;
        yield return new WaitForSeconds(0.5f);
        TriggerActive = false;

    }


}
