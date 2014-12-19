using UnityEngine;
using System.Collections;

public class pipeUpOrDown : MonoBehaviour {

	public AudioSource htiMusic;
	public AudioSource dieMusic;

	IEnumerator OnCollisionEnter (Collision other){
		if(other.gameObject.tag=="Player" && GameManager._intance.GameState==(int)GameManager.GAMEState._PLAYING){
			htiMusic.Play();
			GameManager._intance.GameState=(int)GameManager.GAMEState._END;
			yield return new WaitForSeconds(0.5f);
			dieMusic.Play();
		}
	}

}
