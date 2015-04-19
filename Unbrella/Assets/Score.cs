using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	public static int ScoreGathered;
	Text text;

	void Start () {
		text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = ScoreGathered.ToString() + " / "+(1000+SceneChange.sceneInstanceCount*200).ToString();
	}
}
