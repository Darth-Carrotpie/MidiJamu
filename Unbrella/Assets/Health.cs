using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Health : MonoBehaviour {
	GameObject healthText;
	Text textObject;
	int health = 100;
	// Use this for initialization
	void Start () {
		healthText = GameObject.Find("HealthText");
		textObject = healthText.GetComponent<Text>();
		textObject.text = "Health: " + health.ToString();
	}
	
	void TakeDamage(int damage) {
		health -= damage;
		textObject.text = "Health: " + health.ToString();
	}
	
	
	void OnParticleCollision(GameObject other) {
		TakeDamage (2);
	}
}
