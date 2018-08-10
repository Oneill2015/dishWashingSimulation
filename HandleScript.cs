using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Behaviour h = (Behaviour)GetComponent ("Halo");	
		h.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void LightUp() {
		Behaviour h = (Behaviour)GetComponent ("Halo");	
		h.enabled = true;
	}
}
