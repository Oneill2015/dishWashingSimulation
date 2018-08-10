using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class cupboardOpen : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
		Debug.Log ("cupboard Start");

		

	}

	// Update is called once per frame
	void Update () {
		if(Input.GetAxis ("Fire2") == 1) {
			TaskOnClick ();	

		}

	}
	public void TaskOnClick() {
		Debug.Log ("Cupboard moving");
		transform.RotateAround(transform.position, transform.up, Time.deltaTime * 90f);
	}

}
	