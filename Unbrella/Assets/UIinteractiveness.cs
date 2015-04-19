using UnityEngine;
using System.Collections;

public class UIinteractiveness : MonoBehaviour {

	GameObject UiPause;

	void Start () {
		UiPause = transform.FindChild("Panel Pause").gameObject;
	}
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			if(UiPause.activeSelf){
				UiPause.SetActive(false);
				Time.timeScale = 1;
			}else{
				UiPause.SetActive(true);
				Time.timeScale = 0;
			}
		}
	}
}
