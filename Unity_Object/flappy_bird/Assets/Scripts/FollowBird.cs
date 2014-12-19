using UnityEngine;
using System.Collections;

public class FollowBird : MonoBehaviour {

	// Use this for initialization
	private GameObject bird;
	private Transform birdTransform;
	// Use this for initialization
	void Start () {
		bird = GameObject.FindGameObjectWithTag("Player");
		birdTransform = bird.transform;
	}
	
	// Update is called once per frame
	void Update () {
		float CameraViews;
		if((birdTransform.position.y-2.33f) >2.40f){
			CameraViews = 2.40f;		
		}else if((birdTransform.position.y-2.33f) < -2.40f) {
			CameraViews = -2.40f;
		}else{
			CameraViews = birdTransform.position.y-2.33f;
		};
		
		
		this.transform.position=new Vector3(birdTransform.position.x+4.0f,CameraViews,-10);
	}
}
