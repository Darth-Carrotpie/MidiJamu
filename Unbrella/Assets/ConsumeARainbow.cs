using UnityEngine;
using System.Collections;

public class ConsumeARainbow : MonoBehaviour {
	RainbowManager rainbowMng;
	GameObject rainbowCOnsumeFx;

	void Start () {
		GameObject dumpFolder = GameObject.Find("Buildings");
		dumpFolder = dumpFolder.transform.FindChild("Drains").gameObject;
		rainbowMng =  dumpFolder.GetComponent<RainbowManager>() as RainbowManager;
	}
	
	void Update () {
	
	}
	void OnTriggerEnter( Collider col){
		if(col.gameObject.layer==8){
			col.gameObject.layer=0;
			rainbowMng.aDumpIsActive = false;
			GameObject colHit = col.gameObject;
			colHit.transform.parent = gameObject.transform;
			colHit.transform.localPosition = new Vector3();
			Animator anim = colHit.GetComponent<Animator>();
			anim.SetBool("Consume", true);
			Destroy(colHit, 2f);
			Score.ScoreGathered+=Random.Range(350, 450);
		}
	}

}
