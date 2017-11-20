using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour {
	public float startingSpin;

	void Start () {
		GetComponent<Rigidbody2D> ().AddTorque (Random.Range (-startingSpin, startingSpin), ForceMode2D.Impulse);

	}
	

	//void Update () {
	
		}
		


