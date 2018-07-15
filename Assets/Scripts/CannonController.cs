using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour {

    Vector3 cannonEndOffset;
    Vector3 explosivePosition;
	void Start () {
        cannonEndOffset = new Vector3(0, 1, 0);
        explosivePosition = new Vector3(0, -1, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.other.name == "StartBall")
        {
            DoAction(collision.other.gameObject);

        }
    }

    void DoAction(GameObject ball)
    {
        Rigidbody ballRb = ball.GetComponent<Rigidbody>();
        ballRb.velocity = Vector3.zero;
        ballRb.MovePosition(transform.position +  (transform.rotation * cannonEndOffset));
        Debug.Log("adding explosive force");
        ballRb.AddExplosionForce(4000, transform.rotation * explosivePosition, 3);
    }
}
