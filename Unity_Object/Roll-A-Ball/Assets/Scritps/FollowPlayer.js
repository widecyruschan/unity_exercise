#pragma strict

var Players:GameObject;

function Update () {
	var getVect:Vector3 = Players.GetComponent(Transform).position;
	this.GetComponent(Transform).position=Vector3(getVect.x,getVect.y+8,getVect.z-10);
}