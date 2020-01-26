using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    public GameObject bluePortalPrefab;
    public GameObject orangePortalPrefab;
    public GameObject orangePortal;
    public GameObject bluePortal;
    public float speed = 5.0f;
    float lookHorizontal = 0;
    float lookVertical = 0;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))                                                //These If Statements Are to Difine the Players Movement//
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector3.up * 13 * speed * Time.deltaTime);
        }

        //if (Input.GetKeyDown(KeyCode.Mouse0))                               //A Ray makes sure if something has collided to you infront of you//
        //{
            //transform.Translate(Vector3.ray * speed * Time.deltaTime);
       // }
        //{
         lookHorizontal += Input.GetAxis("Mouse X");
         lookVertical += Input.GetAxis("Mouse Y");
         transform.eulerAngles = new Vector3(-lookVertical, lookHorizontal, 0f);
        //}
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = new Ray();
            ray.origin = Camera.main.transform.position;
            ray.direction = Camera.main.transform.forward;

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.collider.gameObject.name);
                Quaternion rotation = Quaternion.LookRotation(hit.normal, Vector3.up);
                if (bluePortal != null)
                {
                    Destroy(bluePortal);
                }
                bluePortal = (GameObject)Instantiate(bluePortalPrefab, hit.point, rotation);
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = new Ray();
            ray.origin = Camera.main.transform.position;
            ray.direction = Camera.main.transform.forward;

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.collider.gameObject.name);
                Quaternion rotation = Quaternion.LookRotation(hit.normal, Vector3.up);
                if (orangePortal != null)
                {
                    Destroy(orangePortal);
                }
                orangePortal = (GameObject)Instantiate(bluePortalPrefab, hit.point, rotation);
            }
        }
    }
}

