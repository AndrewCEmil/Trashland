using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour {

    Orchestrator orchestrator;
	// Use this for initialization
	void Start () {
        orchestrator = GameObject.Find("OrchestratorObject").GetComponent<Orchestrator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision collision)
    {
        if (collision.other.name == "StartBall")
        {
            orchestrator.TargetHit();
        }
    }
}
