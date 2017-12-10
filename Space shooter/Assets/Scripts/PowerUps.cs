using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour {

	public enum Type {fancy, heart, speed};
	public Type powerupType;
	public Sprite[] images;


	// Use this for initialization
	void Start () {
		switch (powerupType) {
			case Type.fancy:
				gameObject.GetComponent<SpriteRenderer> ().sprite = images [0];
				break;
		case Type.heart:
			gameObject.GetComponent<SpriteRenderer> ().sprite = images [1];
			break;

		case Type.speed:
			gameObject.GetComponent<SpriteRenderer> ().sprite = images [2];
			break;
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log ("We got Hit By Something");

	//	if (powerupType == Type.speed) {
		switch (powerupType) {
		case Type.speed:
			
			other.GetComponent<PlayerController> ().speedBoost();

			break;
		case Type.fancy:
			other.GetComponent<PlayerController> ().enhancedLaser();
			break;
		case Type.heart:
			Health health = other.GetComponent (typeof(Health)) as Health;
			health.IncrementHealth (1);
		
			break;
		default:
			break;
			

	}
		Destroy (this.gameObject);

	}
}