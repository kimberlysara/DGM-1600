using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	public int health;
	//public Sprite[] picture;
	//private int count = 0; 
	//private LevelManager levelManager;
	public GameObject explosionEffect;
	public GameObject[] hearts;


	private void Start () {
		ShowHearts ();
	}

	private void ShowHearts(){
		//turn hearts off
		for (int i = 0; i < hearts.Length; i++) {
			hearts [i].SetActive (false);
		}

		//turn hearts on
		for (int i = 0; i < health; i++) {
			hearts [i].SetActive (true);
		}
	}

	

	


	
		//GetComponent<SpriteRenderer> ().sprite = picture [count];
		//if (health <= 0) {
		//	LevelManager.meteorCount--;
		//	levelManager.CheckMeteorCount ();
		//	Destroy (this.gameObject);
			
		//}
	//}

	public void IncrementHealth (int value){
		health += value;
		if (health <= 0) {
			Destroy (gameObject);
			Instantiate (explosionEffect, transform.position, Quaternion.identity);

		}
		ShowHearts ();
	}
	public int GetHealth() {
		return health; 
		

}
}
