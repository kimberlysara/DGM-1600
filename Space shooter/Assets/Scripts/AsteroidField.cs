using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AsteroidField : MonoBehaviour {
	public GameObject meteor;
	public Transform transform;
	public float xMin;
	public float xMax;
	public const int maxCount = 10;

	void Start () {
		transform = gameObject.GetComponent<Transform> ();
		InvokeRepeating ("spawnRandom", 0f, 1.0f);
	}
	void Update (){

	}
	void spawnRandom (){
		if (Meteor.count < maxCount) {
			float x = Random.Range (xMin, xMax);

			GameObject newGuy = Instantiate (meteor, transform);
			newGuy.transform.position = new Vector3 (x, transform.position.y, transform.position.z);
		}
	}
}



