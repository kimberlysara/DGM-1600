using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AsteroidField : MonoBehaviour {
	public GameObject meteor;
	public Transform transform;
	public float xMin;
	public float xMax;
	public int maxCount = Difficulty.maxMeteors;
	public float spawnTimer;
	public float spawnRate;
	void Start () {
		transform = gameObject.GetComponent<Transform> ();
		//InvokeRepeating ("spawnRandom", 0f, 1.0f);
		spawnTimer = 1.0f;
		spawnRate = 1.0f;
	}
	void Update (){
		if (spawnTimer >= 0) {
			spawnTimer -= Time.deltaTime;
			if (spawnTimer <= 0) {
				spawnRandom();
				spawnTimer = spawnRate; 
			}
		}
	}
	void spawnRandom (){
		if (Meteor.count < maxCount) {
			float x = Random.Range (xMin, xMax);

			GameObject newGuy = Instantiate (meteor, transform);
			newGuy.transform.position = new Vector3 (x, transform.position.y, transform.position.z);
		}
	}
}



