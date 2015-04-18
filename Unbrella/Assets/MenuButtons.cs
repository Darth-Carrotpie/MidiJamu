using UnityEngine;
using System.Collections;

public class MenuButtons : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void toPlay(){
		Application.LoadLevel ("MainScene");
	}

	void Quit(){
		Application.Quit ();
	}
}
