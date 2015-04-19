using UnityEngine;
using System.Collections;

public class Umbrain : MonoBehaviour {

	public GameObject umbrella;
	float timer = 5;
	public float rainSpawnPeriod;
	public float destroyTimer;
	public int mapMatrixY;
	public int mapMatrixX;
	GameObject parentOfUmberllas;

	void Start () {
		parentOfUmberllas = GameObject.Find("UmberlaParrent") as GameObject;
		
	}
	
	void Update () {
		timer+=Time.deltaTime;
		if(timer>rainSpawnPeriod){
			timer=0;
			 
			GameObject newRainPoint = Instantiate (umbrella, GetRainSpawnPoint(), Quaternion.identity) as GameObject;
			newRainPoint.transform.parent = parentOfUmberllas.transform;
			Destroy(newRainPoint, destroyTimer);
		}
	}

	public Vector3 GetRainSpawnPoint(){
		Vector3 spawnPoint = new Vector3();
		float x = Random.Range(0, mapMatrixX) - mapMatrixX/2;
		float y = Random.Range(0, mapMatrixY) - mapMatrixY/2;
//		Debug.Log("x: "+x + "      y: "+y);
		spawnPoint = new Vector3(x, 0, y);
		spawnPoint = spawnPoint*5;
		return spawnPoint;
	}
}
