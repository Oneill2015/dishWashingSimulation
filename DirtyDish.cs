using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtyDish : MonoBehaviour {
	public bool isCleaned = false;
	public GameObject DirtyPlate;
	public GameObject CleanPlate;
	public GameObject Sponge;
	// Use this for initialization

	void Start () {
		bool isCleaned = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.O)) {
			Dead();	

		}
		
	}
	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "sponge") {
			Dead();

		}

	}

	public void Dead()
	{
		CleanPlate = (GameObject)GameObject.Instantiate (CleanPlate, transform.position, Quaternion.identity);
		//CleanPlate.GetComponent<CleanCup> ().isClean ();
		Destroy (DirtyPlate);
		Sponge.GetComponent<SpongeScript> ().CountUp ();



	}
	public void LightUp() {
		Behaviour h = (Behaviour)GetComponent ("Halo");	
		h.enabled = true;
	}



}
