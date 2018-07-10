using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("TRIGGED");
        if (other.name == "Floor")
        {
            return;
        }

        Rigidbody otherRb = other.GetComponent<Rigidbody>();
        otherRb.velocity = otherRb.velocity * -1f;
    }
}
