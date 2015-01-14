using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {

	public int frameNumber	= 10;
	public int frameCount	=0;
	public float timer		=0;
	
	// Use this for initialization
	void Start () {
		//this.rigidbody.velocity=new Vector3(4,0,0);
	}
	
	// Update is called once per frame
	void Update () {	
		if(GameManager._intance.GameState==(int)GameManager.GAMEState._PLAYING){ 
				timer +=Time.deltaTime;
				if(timer>=1.0f/frameNumber){
					frameCount++;
					timer -= 1.0f / frameNumber;
					int  frameIndexs  = frameCount%3;
					this.renderer.material.SetTextureOffset("_MainTex",new Vector2(0.3333f*frameIndexs,0));
				}
			
				if(Input.GetMouseButtonDown(0)){
					audio.Play();
					Vector3 vet=this.rigidbody.velocity;
					this.rigidbody.velocity=new Vector3(vet.x,4,vet.z);
				}	
			}
		
		
	}

		public void gatLift(){
				this.rigidbody.useGravity=true;
				this.rigidbody.velocity=new Vector3(4,0,0);
		}
}
