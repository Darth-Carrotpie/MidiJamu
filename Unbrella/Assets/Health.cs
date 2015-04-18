using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Health : MonoBehaviour {
	GameObject healthText;
	Text textObject;
	int health = 100;
	float lastHitTime = 0;

	public ParticleSystem part;
	public ParticleCollisionEvent[] collisionEvents;

	public Transform rain;

	// Use this for initialization
	void Start () {
		healthText = GameObject.Find("Health Number");
		textObject = healthText.GetComponent<Text>();
		textObject.text = "Tear Capacity: " + health.ToString();

		part = GameObject.Find("Particle System").GetComponent<ParticleSystem> ();
		collisionEvents = new ParticleCollisionEvent[8];
	}
	
	void TakeDamage(int damage) {
		if (Time.time < lastHitTime + 1)
			return;
		
		health -= damage;
		textObject.text = "Health: " + health.ToString();
		lastHitTime = Time.time;
	}

	void OnParticleCollision(GameObject other) {

		part = other.GetComponent<ParticleSystem> ();
		int numCollisionEvents = part.GetCollisionEvents(gameObject, collisionEvents);

		int i = 0;
		while (i < numCollisionEvents) {
			Vector3 pos = collisionEvents[i].intersection;
			GameObject.Instantiate(rain, pos, new Quaternion());
			i++;
		}
		
		TakeDamage (2);
	}
}
