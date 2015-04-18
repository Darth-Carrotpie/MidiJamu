using UnityEngine;
using System.Collections;

public class tearKiller : MonoBehaviour {
	float startTime;

	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > startTime + 5.0)
			Destroy (gameObject);
	}
}
