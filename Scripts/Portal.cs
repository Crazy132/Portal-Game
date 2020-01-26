wusing System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour {

    public Transform exit;									//The Exit of the Portal//						
    public string otherPortalTag;   						//The Name of the Other Portal//			//These Are Fields// 
    public GameObject otherPortal;							//The Concrete of the Other Portal//
void OnCollisionEnter(collision coll) { 
        if(coll.gameObject.tag = = "Player") {
            otherPortal = GameObject.FindGameObjectWithTag(otherPortalTag);
                if(otherPortal != null) {
                coll.transform.position = otherPortal.transform.position;
}