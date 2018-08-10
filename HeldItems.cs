using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeldItems : MonoBehaviour {

	public bool pickup = true;
	public GameObject sponge;
	public Transform guide;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			dragIt();
		}
		if (!pickup && sponge) {
			sponge.transform.position = guide.position;
		}
	}

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "sponge") {
			if (!sponge) {
				sponge = col.gameObject;
			}
		}
	}

	void OnTriggerExit(Collider col) {
		if (col.gameObject.tag == "sponge") {
			if (pickup) {
				sponge = null;
			}
		}
	}

	private void dragIt() {
		sponge.transform.SetParent (guide);
		sponge.GetComponent<Rigidbody>().useGravity = false;
		sponge.transform.position = guide.position + Vector3.forward * 50;
		pickup = false;
		
	}
}
