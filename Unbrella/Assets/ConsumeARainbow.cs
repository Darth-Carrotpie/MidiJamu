using UnityEngine;
using System.Collections;

public class ConsumeARainbow : MonoBehaviour {
	RainbowManager rainbowMng;
	void Start () {
		GameObject dumpFolder = GameObject.Find("Buildings");
		dumpFolder = dumpFolder.transform.FindChild("Drains").gameObject;
		rainbowMng =  dumpFolder.GetComponent<RainbowManager>() as RainbowManager;
	}
	
	void Update () {
	
	}
	void OnTriggerEnter( Collider col){
		rainbowMng.aDumpIsActive = false;
		GameObject colHit = col.gameObject;
		colHit.transform.parent = gameObject.transform;
		Destroy(colHit, 10f);
		Score.ScoreGathered+=Random.Range(100, 500);
	}

}
