using UnityEngine;
using System.Collections;

public class GameMenu : MonoBehaviour {

	// Use this for initialization
	public static GameMenu _instance;
	public GUIText nowScore;
	public GUIText highScore;
	public GUITexture StartTexture;

	void Awake(){
		_instance= this;
		this.gameObject.SetActive(false);
	}

	public void UpdateScure (float nowScore){
		float highScore = PlayerPrefs.GetFloat("score",0);
		if(nowScore > highScore){
			highScore=nowScore;
		}
		PlayerPrefs.SetFloat("score",highScore);
		this.nowScore.text=nowScore +"";
		this.highScore.text=highScore +"";

		if(Input.GetMouseButtonDown(0) && GameManager._intance.GameState==(int)GameManager.GAMEState._END){
			Rect rects= StartTexture.GetScreenRect();
			Vector3 mousePos= Input.mousePosition;
			if(mousePos.x>rects.x &&
			mousePos.x< (rects.x + rects.width) &&
			mousePos.y>rects.y && 
			mousePos.y< (rects.y + rects.height)){
			 Application.LoadLevel(0);
			}
		}
	}
}
