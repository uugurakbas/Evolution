using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rigidbody;
    public int moveSpeed = 10, rightLeftSpeed = 100;
    Vector3 lastMousePos, firstMousePos;
    public float bounds = 5;
    public Transform CloneTransform;
    public GameObject RockPrefab;


    [HideInInspector] 
    public GameObject Clone;
    public bool active = false;

    void Awake()
    {
        rigidbody = this.gameObject.GetComponent<Rigidbody>();

    }
    private void Start()
    {

    }

    private void FixedUpdate()
    {
        //StartCoroutine(RockFire());
        if (active == false)
        {
            StartCoroutine(RockFire());
        }
        else
        {

            Destroy(Clone);
            active = false;

        }
    }
    
    void Update()
    {
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


    }

    public IEnumerator RockFire()
    {

        if (active == false)
        {
            yield return new WaitForSeconds(2);
            Clone = Instantiate(RockPrefab, CloneTransform.position, Quaternion.identity) as GameObject;
            Clone.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 100), ForceMode.Impulse);
            active = true;
        }


    }
}
