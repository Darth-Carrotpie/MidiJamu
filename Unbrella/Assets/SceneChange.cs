using UnityEngine;
using System.Collections;

public class SceneChange : MonoBehaviour {
	public static int sceneInstanceCount;
	GameObject animBcgkImg;
	float waitCounter;
	// Use this for initialization
	void Start () {
		sceneInstanceCount = 0;
		DontDestroyOnLoad(this);

	}
	
	// Update is called once per frame
	void Update () {
		if(Score.ScoreGathered > 100){
			sceneInstanceCount++;

			animBcgkImg = GameObject.Find("Canvas").transform.FindChild("Animation Bckg").gameObject;
			animBcgkImg.SetActive(true);
			waitCounter+=Time.deltaTime;
		}

		if(waitCounter > 7.6f){
			Score.ScoreGathered = 0;
			waitCounter=0f;
			Application.LoadLevel("MainScene");
		}
	}
}
