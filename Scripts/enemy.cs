using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
	GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(
        	transform.position, player.transform.position, 9 * Time.deltaTime);
    }

     void OnCollisionEnter(Collision coll) {
        if (coll.gameObject.tag == "Player"){
            Vector3 dir = coll.transform.position - transform.position
            + new Vector3(0, 0.7f, 0);
            coll.gameObject.GetComponent<Rigidbody>().AddForce(
            dir * 15,
            ForceMode.Impulse );
            }
            
        }
    }
