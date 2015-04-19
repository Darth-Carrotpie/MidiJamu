using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelNrUpdate : MonoBehaviour {
	Text text;
	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		text.text="Level: "+(SceneChange.sceneInstanceCount+1).ToString();
	}
}
