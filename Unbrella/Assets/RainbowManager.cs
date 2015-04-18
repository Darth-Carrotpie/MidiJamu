using UnityEngine;
using System.Collections;

public class RainbowManager : MonoBehaviour {
	
	public GameObject rainbow;
	//float timer = 5;
	//public float rainbowSpawnPeriod;
	public GameObject[] dumps;
	public bool aDumpIsActive =  false;
	
	void Start () {		
	}
	
	void Update () {
		//timer+=Time.deltaTime;
		if(/*timer>rainbowSpawnPeriod &&*/ !aDumpIsActive){
			//timer=0;
			int i = Random.Range(0, dumps.Length);
			GameObject newRainPoint = Instantiate (rainbow) as GameObject;
			newRainPoint.transform.position =  dumps[i].transform.FindChild("RainbowSpawnPoint").position;
			newRainPoint.name="RainBow";
			aDumpIsActive = true;
		}
	}
	
}
