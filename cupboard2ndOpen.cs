using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class cupboard2ndOpen : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("cupboard1 Start");

		

	}

	// Update is called once per frame
	void Update () {
		if(Input.GetAxis ("Fire2") == 1) {
			TaskOnClick ();	
		}

	}
	public void TaskOnClick() {
		Debug.Log ("cupboard 1 Opening!");
        transform.RotateAround(transform.position, transform.up, Time.deltaTime * 90f);
    }
}
	/*var pointB = Vector3;

	function Start () {
		var pointA = transform.position;
		while (true) {
			yield MoveObject(transform, pointA, pointB, 3.0);
			yield MoveObject(transform, pointB, pointA, 3.0);
		}
	}

	function MoveObject (thisTransform : Transform, startPos : Vector3, endPos : Vector3, time : float) {
		var i = 0.0;
		var rate = 1.0/time;
		while (i &lt; 1.0) {
			i += Time.deltaTime * rate;
			thisTransform.position = Vector3.Lerp(startPos, endPos, i);
			yield; 
		}
	} */     
