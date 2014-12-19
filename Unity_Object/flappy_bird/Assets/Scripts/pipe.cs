using UnityEngine;
using System.Collections;

public class pipe : MonoBehaviour {

	// Use this for initialization
	void Start () {
		RandomGeneratePosition();
	}
	
	
	public void RandomGeneratePosition () {
		float pos_y = Random.Range(-0.13f,0.15f);
		this.transform.localPosition=new Vector3(this.transform.localPosition.x,pos_y,this.transform.localPosition.z);
	}
	
	void OnTriggerExit (Collider other) {
		if(other.tag=="Player" && GameManager._intance.GameState==(int)GameManager.GAMEState._PLAYING){
			GameManager._intance.scoce++;
			audio.Play();
		}
	}
	void OnGUI (){
		GUILayout.Label("Scoce " + GameManager._intance.scoce);
	}
}
