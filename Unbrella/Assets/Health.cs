using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Health : MonoBehaviour {
	GameObject healthText;
	Text textObject;
	public static int health = 100;
	float lastHitTime = 0;

	public ParticleSystem part;
	public ParticleCollisionEvent[] collisionEvents;

	public AudioSource grojikas;
	public AudioClip garsukas;

	public Transform rain;

	// Use this for initialization
	void Start () {
		healthText = GameObject.Find("Health Number");
		textObject = healthText.GetComponent<Text>();
		textObject.text = "Water: " + health.ToString();

//		part = GameObject.Find("Particle System").GetComponent<ParticleSystem> ();
		collisionEvents = new ParticleCollisionEvent[8];
	}
	
	void TakeDamage(int damage) {
		if (Time.time < lastHitTime + 1)
			return;

		grojikas.PlayOneShot (garsukas);
		health -= damage;
		textObject.text = "Water: " + health.ToString();
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
		
		TakeDamage (5+SceneChange.sceneInstanceCount*10);
	}
}
