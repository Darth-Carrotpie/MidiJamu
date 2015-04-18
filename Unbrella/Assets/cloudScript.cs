using UnityEngine;
using System.Collections;

public class cloudScript : MonoBehaviour {

	public float maxX;
	public float speed;
	public RectTransform myTransform;
	float initScale;

	// Use this for initialization
	void Start () {
		initScale = myTransform.localScale.x;
	}
	
	// Update is called once per frame
	void Update () {
		float newX = myTransform.anchoredPosition.x + speed * Time.deltaTime;

		if (newX > maxX)
			newX -= 2.0f * maxX;

		float newScale = initScale * (3 + Mathf.Sin (newX / 40f)) / 4f;
		myTransform.localScale = new Vector3 (newScale, newScale * 0.8f, newScale);

		myTransform.anchoredPosition = new Vector2 (newX, myTransform.anchoredPosition.y);
	}
}
