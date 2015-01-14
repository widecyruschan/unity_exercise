#pragma strict

private var oneTextrue:Texture2D;
private var allTexture:Object[];

function OnGUI(){
	if(GUI.Button(Rect(5,20,100,60),"LoadOneTex")){
		if(oneTextrue ==null){
			oneTextrue=Resources.Load("oneTextrue/Grass");
		}
	}
	
	if(GUI.Button(Rect(5,140,100,60),"LoadAllTex")){
		if(allTexture ==null){
			allTexture=Resources.LoadAll("allTexture");
		}
	}
	
	if(oneTextrue !=null){
		GUI.DrawTexture(Rect(120,20,120,120),oneTextrue,ScaleMode.StretchToFill,true,0);
	}
	
	if(allTexture !=null){
		for(var i=0;i<allTexture.length;i++){
			GUI.DrawTexture(Rect(120+i*130,140,120,120),allTexture[i],ScaleMode.StretchToFill,true,0);
		}
	}
}