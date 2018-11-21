using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Alpha1)){
			Invoke( "ChangeLevel", 3.0f );
			Application.LoadLevel("scene1");
		}else if(Input.GetKeyDown(KeyCode.Alpha2)){
			Invoke( "ChangeLevel", 3.0f );
			Application.LoadLevel("scene2");
		}else if(Input.GetKeyDown(KeyCode.Alpha3)){
			Invoke( "ChangeLevel", 3.0f );
			Application.LoadLevel("scene3");
		}else if(Input.GetKeyDown(KeyCode.Alpha4)){
			Invoke( "ChangeLevel", 3.0f );
			Application.LoadLevel("scene4");
		}
	}
}


