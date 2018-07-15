using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorController : MonoBehaviour {

    Collider myCollider;
	// Use this for initialization
	void Start () {
        myCollider = GetComponent<Collider>();
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
        var point = collision.contacts[0].point;
        var dir = collision.contacts[0].normal;
        point -= dir;
        RaycastHit hitInfo;
        if (myCollider.Raycast(new Ray(point, dir), out hitInfo, 2))
        {
            //hitInfo.normal is relative to object; transform to world normal
            var normal = transform.rotation * hitInfo.normal;
            //r=d−2(d⋅n)n
            otherRb.velocity = collision.relativeVelocity - 2f * Vector3.Dot(collision.relativeVelocity, normal) * normal;
        } else
        {
            Debug.Log("failed raycast");
        }
    }
}
