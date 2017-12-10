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
	public static int count = 0;
	//public Text scoreBoard;

	void Start () {
		count++;
		rigid = GetComponent<Rigidbody2D> ();
		rigid.AddTorque (Random.Range (-startingSpin, startingSpin), ForceMode2D.Impulse);
		scoreScript = FindObjectOfType<ScoreBoard>();
		Vector3 force = new Vector3(0,-Random.Range(0.9f,5f), 0);
		rigid.velocity = force;
	}
	void Update (){
		if ((Mathf.Abs(rigid.transform.position.x) >= 15) || (Mathf.Abs(rigid.transform.position.y) >= 15)) {
			Destroy (gameObject);
		}
	}

	void OnDestroy (){
		count--;
	}
	private void OnCollisionEnter2D(Collision2D coll){
		Debug.Log (coll.gameObject.name);
		if (coll.gameObject.name == "player") {
			coll.gameObject.GetComponent<Health>().IncrementHealth(-1);
		}
		if (coll.gameObject.name != "Meteor(Clone)") {
			DecrementHealth (1);
		}
	}

	public void DecrementHealth (int value){
		health -= value;
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



