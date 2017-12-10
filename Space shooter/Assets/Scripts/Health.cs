using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	public int health;
	public LevelManager myLevelManager;
	//public Sprite[] picture;
	//private int count = 0; 
	//private LevelManager levelManager;
	public GameObject explosionEffect;
	public GameObject[] hearts;
	public int max;


	private void Start () {
		max = 5;
		ShowHearts ();

	}

	void OnDestroy (){
		 
			print ("lol");
			LevelManager.manager.LevelLoad ("GameOver");
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



	public void IncrementHealth (int value){
		if (health + value <= max) {

			health += value;
		}
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

