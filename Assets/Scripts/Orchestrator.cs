using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orchestrator : MonoBehaviour {

    GameObject startBall;
    Rigidbody startBallRb;
	// Use this for initialization
	void Start () {
        startBall = GameObject.Find("StartBall");
        startBallRb = startBall.GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    void Update() {
        if (Input.anyKeyDown) {
            startBallRb.useGravity = true;
        }
	}

    public void TargetHit()
    {
        //TODO
    }
}
