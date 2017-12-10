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
	public GameObject powerUps;
	//public Text scoreBoard;

	void Start () {
		count++;
		rigid = GetComponent<Rigidbody2D> ();
		rigid.AddTorque (Random.Range (-startingSpin, startingSpin), ForceMode2D.Impulse);
		scoreScript = FindObjectOfType<ScoreBoard>();
		Vector3 force = new Vector3(0,-Random.Range(35f,150f), 0);
		rigid.velocity = force;

		float scale = Random.Range (33f,50f);
		rigid.transform.localScale = new Vector3(scale,scale,scale);
	}
	void Update (){
		if ((Mathf.Abs(rigid.transform.position.x) >= 225) || (Mathf.Abs(rigid.transform.position.y) >= 225)) {
			Destroy (gameObject);
		}
	}

	void OnDestroy (){
		count--;

	}
	private void OnCollisionEnter2D(Collision2D coll){
		print ("hi");
		Debug.Log (coll.gameObject.name);
		if (coll.gameObject.name == "player") {
			coll.gameObject.GetComponent<Health>().IncrementHealth(-1);
		}
		if (coll.gameObject.name == "Laser(Clone)") {
			ScoreBoard.AddPoints(10);
		}
		if (coll.gameObject.name != "Meteor(Clone)") {
			DecrementHealth (1);
		}
	
	}

	public void DecrementHealth (int value){
		health -= value;
		if (health <= 0) {
			GameObject explosion = Instantiate (explosionEffect, transform.position, Quaternion.identity);
			//explosion.velocity = gameObject.velocity;
			//GetComponent<Rigidbody2D> ();
			genPowerup();
			Destroy (gameObject);

			//IncrementScore();
		}

	

	}
	public void genPowerup(){
		int roll = Random.Range (0, 100);
		print (roll);
		if (roll >= 70 && roll < 80) {
			GameObject obj = Instantiate (powerUps, transform.position, Quaternion.identity);
			PowerUps pu = obj.GetComponent<PowerUps> ();
			pu.powerupType = PowerUps.Type.fancy;
		}
		if (roll >= 80 && roll < 90) {
			GameObject obj = Instantiate (powerUps, transform.position,Quaternion.identity);
			PowerUps pu = obj.GetComponent<PowerUps> ();
			pu.powerupType = PowerUps.Type.heart;
		}if (roll >= 90 && roll < 100) {
			GameObject obj = Instantiate (powerUps, transform.position, Quaternion.identity);
			PowerUps pu = obj.GetComponent<PowerUps> ();
			pu.powerupType = PowerUps.Type.speed;
		}
	}

}



