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
		if(col.gameObject.layer==8){
			rainbowMng.aDumpIsActive = false;
			GameObject colHit = col.gameObject;
			GameObject basePoint = colHit.transform.parent.gameObject;
			basePoint.transform.parent = gameObject.transform;
			basePoint.transform.localPosition = new Vector3();
			Animator anim = basePoint.GetComponent<Animator>();
			anim.SetBool("Consume", true);
			Destroy(basePoint, 10f);
			Score.ScoreGathered+=Random.Range(100, 500);
		}
	}

}
