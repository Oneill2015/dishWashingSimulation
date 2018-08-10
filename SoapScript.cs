using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoapScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Behaviour h = (Behaviour)GetComponent ("Halo");	
		h.enabled = true;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void turnOff() {
		Behaviour h = (Behaviour)GetComponent ("Halo");	
		h.enabled = false;
	}
}
