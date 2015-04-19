using UnityEngine;
using System.Collections;

public class SceneChange : MonoBehaviour {
	public static int sceneInstanceCount;
	GameObject animBcgkImg;
	GameObject looseBckg;
	float waitCounter;
	GameObject parentOfUmberllas;
	GameObject umberllaMng;
	// Use this for initialization
	void Start () {
	//	DontDestroyOnLoad(this);
		parentOfUmberllas = GameObject.Find("UmberlaParrent") as GameObject;
		umberllaMng = GameObject.Find("Umbrella Manager") as GameObject;

	}
	
	// Update is called once per frame
	void Update () {
		if(Score.ScoreGathered > 1000+sceneInstanceCount*200){
			animBcgkImg = GameObject.Find("Canvas").transform.FindChild("Animation Bckg").gameObject;
			animBcgkImg.SetActive(true);
			waitCounter+=Time.deltaTime;
			Destroy(umberllaMng);

			Destroy(parentOfUmberllas);
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
			Destroy(umberllaMng);
			Destroy(parentOfUmberllas);
			Health.health=100;
		}
	}
	public void goToMainMeniu(){
		Application.LoadLevel("Menu");
	}
}