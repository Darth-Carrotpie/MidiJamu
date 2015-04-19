using UnityEngine;
using System.Collections;

public class audioScript : MonoBehaviour {
	public GameObject musicObject;

	// Use this for initialization
	void Start () {
		if (GameObject.Find ("Music(Clone)") == null) {
			musicObject = Instantiate (musicObject);
			DontDestroyOnLoad (musicObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
