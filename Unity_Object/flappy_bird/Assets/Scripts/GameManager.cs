using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public enum GAMEState { _MENU , _PLAYING , _END };
	public static GameManager _intance;
	
	public Transform fristBg;
	public int scoce =0;
	public int GameState	= (int)GAMEState._MENU;
	
	private GameObject bird;
	
	// Use this for initialization
	 void Awake() {
		GameState	= (int)GAMEState._MENU;
		_intance = this;
		bird = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if(GameState==(int)GAMEState._MENU){
			if(Input.GetMouseButtonDown(0)){
				GameState=(int)GAMEState._PLAYING;
				bird.SendMessage("gatLift");
			}		
		}
		if(GameState==(int)GAMEState._END){
			GameMenu._instance.gameObject.SetActive(true);
			GameMenu._instance.UpdateScure(scoce);
		}
	}
}
