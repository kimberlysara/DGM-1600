using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour {

	public enum Type {fancy ,shield, speed};
	public Type powerupType;
	public Sprite[] images;


	// Use this for initialization
	void Start () {
		switch (powerupType) {
			case Type.fancy:
				gameObject.GetComponent<SpriteRenderer> ().sprite = images [0];
				break;
		case Type.shield:
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
			other.GetComponent<PlayerController> ().speed *= 2;
			break;
		case Type.fancy:
			
			break;
		case Type.shield:
			
			break;
		default:
			break;
			

	}
		Destroy (this.gameObject);

}
}