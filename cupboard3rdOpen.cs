using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class cupboard3rdOpen : MonoBehaviour {
	bool check = false;
	public GameObject handle;
	public GameObject handle2;
	public GameObject handle3;
	public GameObject handle4;
	public GameObject handle5;
	public GameObject handle6;



	// Use this for initialization
	void Start () {
		Debug.Log ("cupboard2 Start");


		

	}

	// Update is called once per frame
	void Update () {
		if (check = false) {
			if (GameObject.Find ("sponge").GetComponent<SpongeScript>().count == 4) {
				Debug.Log ("this should work");
	
				check = true;
				LightUpDoors ();
			}
		}
	}
	public void TaskOnClick() {
		Debug.Log ("cupboard 2 Opening!");
		//transform.RotateAround(transform.position, transform.up, Time.deltaTime * 90f);
		transform.Rotate(0,90,0);
	}
	public void LightUpDoors() {
		handle.GetComponent<HandleScript> ().LightUp ();
		handle2.GetComponent<HandleScript> ().LightUp ();
		handle3.GetComponent<HandleScript> ().LightUp ();
		handle4.GetComponent<HandleScript> ().LightUp ();
		handle5.GetComponent<HandleScript> ().LightUp ();
		handle6.GetComponent<HandleScript> ().LightUp ();

			
	}
}
	
		//https://answers.unity.com/questions/418609/how-do-i-check-if-bool-is-true-from-another-script.html
		//https://answers.unity.com/questions/172436/how-to-disableenable-halo-component-via-script.html
		//https://forum.unity.com/threads/turning-halo-component-on-and-off-through-scripting.122951/
		//https://answers.unity.com/questions/187026/enabledisable-halo-component-in-c.html

//GameObject.Find ("CleanPlate(Clone)").GetComponent<CleanCup> ().isCleaned && GameObject.Find ("CleanCup(Clone)").GetComponent<CleanCup> ().isCleaned && 
//GameObject.Find ("CleanCup (1)(Clone)").GetComponent<CleanCup> ().isCleaned && GameObject.Find ("CleanPlate (1)(Clone)").GetComponent<CleanCup> ().isCleaned