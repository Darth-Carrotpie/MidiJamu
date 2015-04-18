using UnityEngine;
using System.Collections;

public class SceneChange : MonoBehaviour {
	public static int sceneInstanceCount;
	GameObject animBcgkImg;
	GameObject looseBckg;
	float waitCounter;
	// Use this for initialization
	void Start () {
	//	DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update () {
		if(Score.ScoreGathered > 100){
			animBcgkImg = GameObject.Find("Canvas").transform.FindChild("Animation Bckg").gameObject;
			animBcgkImg.SetActive(true);
			waitCounter+=Time.deltaTime;
		}

		if(waitCounter > 7.6f){
			Score.ScoreGathered = 0;
			waitCounter=0f;
			Application.LoadLevel("MainScene");
			sceneInstanceCount++;

	}

		if(Health.health<=0)
		{
			looseBckg = GameObject.Find("Canvas").transform.FindChild("Loose bckg").gameObject;

			looseBckg.SetActive(true);
		}
	}
	public void goToMainMeniu(){
		Application.LoadLevel("Menu");
	}
}