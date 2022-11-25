using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rigidbody;
    public int moveSpeed = 10, rightLeftSpeed = 100, years = 0, yearsPlus,people = 0,peoplePlus;
    Vector3 lastMousePos, firstMousePos;
    public float bounds = 5;
    public Transform CloneTransform;
    public GameObject RockPrefab;


    [HideInInspector] 
    public GameObject Clone;
    public bool active = true;

    void Awake()
    {
        rigidbody = this.gameObject.GetComponent<Rigidbody>();

    }
    private void Start()
    {
        StartCoroutine(RockFire());
    }
    
    void Update()
    {

        //MOVE
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -bounds, bounds), transform.position.y, transform.position.z);
        transform.position += transform.forward * Time.deltaTime * moveSpeed;



        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Input.mousePosition;
            pos.z = 10;
            firstMousePos = Camera.main.ScreenToWorldPoint(pos);

        }

        if (Input.GetMouseButton(0))
        {
            Vector3 pos = Input.mousePosition;
            pos.z = 10;
            lastMousePos = Camera.main.ScreenToWorldPoint(pos);
            Vector3 dif = lastMousePos - firstMousePos;
            transform.position += new Vector3(dif.x, 0, 0) * Time.deltaTime * rightLeftSpeed;
            firstMousePos = lastMousePos;
        }
        //MOVE
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Trigger")
        {
            yearsPlus = other.GetComponent<Years_People>().YearsPlus;
            peoplePlus = other.GetComponent<Years_People>().PeoplePlus;

            Destroy(other.gameObject);

            years = yearsPlus + years;
            people = peoplePlus + people;

            Debug.Log(years);
            Debug.Log(people);
        }
    }

    public IEnumerator RockFire()
    {

        while (active == true)
        {
            
            Clone = Instantiate(RockPrefab, CloneTransform.position, Quaternion.identity) as GameObject;
            Clone.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 100), ForceMode.Impulse);
            yield return new WaitForSeconds(1f);
            Destroy(Clone);
            yield return new WaitForSeconds(0.5f);
        }


    }
}
