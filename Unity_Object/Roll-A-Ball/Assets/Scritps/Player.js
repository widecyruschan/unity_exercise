#pragma strict

var i:int=0;
function Update () {
	this.rigidbody.AddForce(Vector3(Input.GetAxis("Horizontal")*10,0,Input.GetAxis("Vertical")*10));
}

function OnTriggerEnter (other : Collider) {
		//Debug.Log("OnTriggerEnter");
	if(other.gameObject.name == "Food"){
		Destroy(other.gameObject);
		i++;
		Debug.Log("Eat a Food");
		if(i==10){
		print("you win");
		Debug.Log("Eat all Food");
		}
	}
		
		
}