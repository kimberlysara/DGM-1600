using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick: MonoBehaviour {

	public int health;
	public Sprite[] picture;
	private bool destroying = false;
	private int count = 0;
	private LevelManager levelManager;

void Update(){
		if (picture.Length > count) {
			GetComponent<SpriteRenderer> ().sprite = picture [count];
		}
	}
		


	void Start(){
		levelManager = FindObjectOfType<LevelManager> ();
	}

	void OnCollisionEnter2D (Collision2D myCollider){
		print ("COLLISION. Health: " + health);
		health--;
		count++;
		//if (count > picture.Length - 1) {
		//count--;
		if (health <= 0) {
			print ("I MUST DIE");
			LevelManager.brickCount--;
			levelManager.CheckBrickCount ();

			destroying = true;
		}

		if (!destroying && picture.Length > count) {
			GetComponent<SpriteRenderer> ().sprite = picture [count];
		}

		if (destroying) {
			Destroy (this.gameObject);
		}
	}
}

	
