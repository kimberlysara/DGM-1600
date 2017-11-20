using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour {

	public LevelManager myLevelManager;

	void Start () {
		
	}

	public void OnTriggerEnter2D(Collider2D trigger){
		//print ("triggered floor");
		//print (trigger.name);
		if (trigger.name == "Ball") {
			myLevelManager.LevelLoad ("GameOver");
		}
		}
		
	}

		


