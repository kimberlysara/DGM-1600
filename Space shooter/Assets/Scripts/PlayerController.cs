using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	//public Vector3 velocity;
	public float shipSpeed;
	public float speed = 1.0f;

	public ParticleSystem particles;

	public GameObject projectile;
	public Transform shotPos;
	public float shotForce;

	void Start () {
		
	}




	// Update is called once per frame
	void Update () {
		var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
			transform.position += move * speed * Time.deltaTime;
		//check for button push
		if (Input.GetKey (KeyCode.A)) {
			//Vector3 position = this.transform.position;
			//position.x--;
			//this.transform.position = position;
			particles.Emit (1);
		}

		if (Input.GetKey (KeyCode.D)) {
			//Vector3 position = this.transform.position;
			//position.x++;
			//this.transform.position = position;
		particles.Emit (1);
		}


		if (Input.GetKey(KeyCode.S)) {
		//	Vector3 position = this.transform.position;
		//	position.y--;
			//this.transform.position = position;
			particles.Emit (1);
	}
	if (Input.GetKey(KeyCode.W)) {
		//	Vector3 position = this.transform.position;
		//	position.y++;
		//	this.transform.position = position;
		particles.Emit (1);
		}

	//else {
	//	particles.Stop ();

	//}

		if (Input.GetButtonUp ("Fire1")) {
		GameObject shot = Instantiate (projectile, shotPos.position, shotPos.rotation) as GameObject; 
			shot.GetComponent<Rigidbody2D> ().AddForce (shotPos.up * shotForce);
				//shotPos.AddForce (shotPos.forward * shotForce)

		}
		//switch (health) {
		//case 1:
		//default:
		//	break;
		//}
	}
				
	}

