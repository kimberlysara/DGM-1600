using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	//public Vector3 velocity;
	public float shipSpeed;
	public float speed = 150.0f;
	public const float startSpeed = 150.0f;
	public float speedTimer;
	public float laserTimer;
	public float fireRate;
	public float enhancedLaserTimer;
	public ParticleSystem particles;
	public GameObject speedIcon; 
	public GameObject projectile;
	public Transform shotPos;
	public float shotForce;
	public GameObject laserCounter;

	void Start () {
		speedIcon.SetActive (false);
		fireRate = 0.8f;
		print (GetComponent<Health>().GetHealth() ); 
	}
	public void enhancedLaser (){
		fireRate = 0.4f;
		enhancedLaserTimer = 5.0f;
	}

	public void speedBoost (){
		//print (speed);
	   speed += 100f;
		speedTimer = 3.0f;

		speedIcon.SetActive (true);
	}


	// Update is called once per frame
	void Update () {
		if (speedTimer > 0) {
			speedTimer -= Time.deltaTime;
			if (speedTimer <= 0) {
				speed = startSpeed;
				speedIcon.SetActive (false);
			}
		}
		if (laserTimer > 0) {
			laserTimer -= Time.deltaTime;

		}
		if (enhancedLaserTimer > 0) {
			enhancedLaserTimer -= Time.deltaTime;
			if (enhancedLaserTimer <= 0) {
				fireRate = 0.8f;
			}
		}
	
		var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
			transform.position += move * speed * Time.deltaTime;
		//check for button push
		if (Input.GetKey (KeyCode.A)) {
			particles.Emit (1);
		}

		if (Input.GetKey (KeyCode.D)) {
		particles.Emit (1);
		}


		if (Input.GetKey(KeyCode.S)) {
			particles.Emit (1);
	}
		if (Input.GetKey (KeyCode.W)) {
			particles.Emit (1);
		}
		if (Input.GetButtonUp ("Fire1")) {
			if (laserTimer <= 0){
		GameObject shot = Instantiate (projectile, shotPos.position, shotPos.rotation) as GameObject; 
			shot.GetComponent<Rigidbody2D> ().AddForce (shotPos.up * shotForce);
				laserTimer = fireRate;
				//shotPos.AddForce (shotPos.forward * shotForce)
			}
		}
		//switch (health) {
		//case 1:
		//default:
		//	break;
		//}
	}
				
	}

