using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpongeScript : MonoBehaviour {
	public GameObject sponge;
	public int count;
	public GameObject soap;
	public GameObject Dish1;
	public GameObject Dish2;
	public GameObject Cup1;
	public GameObject Cup2;
	public GameObject Doors;


	// Use this for initialization
	void Start () {
		Behaviour h = (Behaviour)GetComponent ("Halo");	
		h.enabled = true;
		count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
			
			
	}
	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "soap") {
			Lights();
		}

	}
	void Lights() {

		soap.GetComponent<SoapScript>().turnOff ();

		Dish1.GetComponent<DirtyDish>().LightUp ();
		Dish2.GetComponent<DirtyDish>().LightUp ();
		Cup1.GetComponent<DirtyDish>().LightUp ();
		Cup2.GetComponent<DirtyDish>().LightUp ();


	}
	public void CountUp() {
		count = count + 1;
		Debug.Log (count);
		if (count == 4) {
			Doors.GetComponent<cupboard3rdOpen> ().LightUpDoors ();
		}
	}
}
