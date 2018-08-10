#pragma strict
//https://www.youtube.com/watch?v=gBGzYW1oEHY

public var isRunning = false;
private var anim:Animation;

function Awake () {
	anim = this.GetComponent.<Animation>();
}

function OnMouseDown() {
	if(isRunning) {
		playAnim("sink_on");
		Debug.Log("Cool");
	}else {
		playAnim("sink_off");
	}

	isRunning = !isRunning;
}

function playAnim(s:String) {
	anim.Blend(s);

}