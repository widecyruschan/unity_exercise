#pragma strict

function Start () {
	for(var y=0; y<5; y++){
	 	for (var x=0 ;x<5; x++){
			var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			cube.transform.localScale=Vector3(0.8f,0.8f,0.8f);
			cube.transform.position = Vector3(x-2.5f,y-0.5f,0);
		}
	
	}
}

function Update () {

}