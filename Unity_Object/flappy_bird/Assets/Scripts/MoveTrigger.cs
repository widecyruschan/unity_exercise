using UnityEngine;
using System.Collections;

public class MoveTrigger : MonoBehaviour {

	public Transform currentBg;
	public pipe pipe1;
	public pipe pipe2;
	// Use this for initialization
	public void OnTriggerEnter (Collider other) {
		if(other.tag == "Player"){
			
			Transform firstBg = GameManager._intance.fristBg;
			currentBg.position=new Vector3(firstBg.position.x+10,currentBg.position.y,currentBg.position.z);
			GameManager._intance.fristBg=currentBg;
			pipe1.RandomGeneratePosition();
			pipe2.RandomGeneratePosition ();

			
		}
	}

}
