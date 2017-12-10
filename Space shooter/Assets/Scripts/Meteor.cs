using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meteor : MonoBehaviour {
	public float startingSpin;
	public int health;
	public GameObject explosionEffect;
	private Rigidbody2D rigid; 
	public GameObject scoreboard;
	public ScoreBoard scoreScript;
	//public Text scoreBoard;

	void Start () {
		GetComponent<Rigidbody2D> ().AddTorque (Random.Range (-startingSpin, startingSpin), ForceMode2D.Impulse);
		scoreScript = FindObjectOfType<ScoreBoard>();
	}

	private void OnCollisionEnter2D(Collision2D coll){
		coll.gameObject.GetComponent<Health>().IncrementHealth(-1);
	}

	public void IncrementHealth (int value){
		health += value;
		if (health <= 0) {
			Destroy (gameObject);
			Instantiate (explosionEffect, transform.position, Quaternion.identity);
			//IncrementScore();
		}
	

	}

	private void IncrementScore(){
		scoreboard.GetComponent<ScoreBoard> ().IncrementScoreBoard (10);
	}

}



