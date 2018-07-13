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

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("TRIGGED");
        if (collision.collider.name == "Floor")
        {
            return;
        }

        Rigidbody otherRb = collision.collider.GetComponent<Rigidbody>();
        otherRb.velocity = otherRb.velocity * -1f;
    }
}
