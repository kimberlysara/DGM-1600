using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {

	public float lifetime;
	public float speed;
	public int damage;



	void Update () {
		lifetime -= Time.deltaTime;
		if (lifetime <= 0) {
			Destroy (this.gameObject);
		}
		}

		//transform.Translate (Vector3.up * speed * Time.deltaTime);


	void OnCollisionEnter2D (Collision2D other){
		Destroy (this.gameObject);
	}
 }
