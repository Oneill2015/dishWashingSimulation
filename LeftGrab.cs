using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftGrab : MonoBehaviour {
	private GameObject grabbedObject;
	public cupboardOpen other;
	public GameObject cupboard;
	public GameObject cupboardDoor;
	public GameObject cupboard1;
	public GameObject cupboardDoor1;
	public GameObject cupboard2;
	public GameObject cupboardDoor2;

		private bool grabbing;
	public float grabRadius;
	public LayerMask grabMask;
	public OVRInput.Controller controller;


	// Use this for initialization
	void Start () {

	}
	void GrabObject() {
		grabbing = true;

		RaycastHit[] hits;
		hits = Physics.SphereCastAll (transform.position, grabRadius, transform.forward, 0f, grabMask);

		if (hits.Length > 0) {
			int closestHit = 0;
			for (int i = 0; i < hits.Length; i++) {
				if (hits [i].distance < hits [closestHit].distance)
					closestHit = i;
			}
			grabbedObject = hits [closestHit].transform.gameObject;
			Debug.Log (grabbedObject.tag);
			if (grabbedObject.tag == "cabinet") {
				Debug.Log ("Cabinet Grabbed");
				grabbedObject.GetComponent<cupboard3rdOpen>().TaskOnClick ();
				Debug.Log ("Grabbing Cabinet Working!");

			} else {
				grabbedObject.GetComponent<Rigidbody> ().isKinematic = true;
				grabbedObject.transform.position = transform.position;
				grabbedObject.transform.parent = transform;
			}
		}
	}

	void DropObject() {
		grabbing = false;


		if (grabbedObject != null) {
			if (grabbedObject.tag != "cabinet") {
				grabbedObject.transform.parent = null;
				grabbedObject.GetComponent<Rigidbody> ().isKinematic = false;

				grabbedObject.GetComponent<Rigidbody> ().velocity = OVRInput.GetLocalControllerVelocity (controller);
				grabbedObject = null;
			} else
				grabbedObject = null;
		}
	}

	// Update is called once per frame
	//https://www.youtube.com/watch?time_continue=79&v=mFFta9OszzA
	void Update () {
		if (!grabbing && Input.GetAxis ("Oculus_GearVR_LIndexTrigger") == 1) {
			GrabObject();
			Debug.Log ("Left Hand Working!");
		}
		if (grabbing && Input.GetAxis ("Oculus_GearVR_LIndexTrigger") < 1) {
			DropObject();
		}
	}
}
