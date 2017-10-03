using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Threading;

public class StoryScript: MonoBehaviour {

	public Text textobject;

	public enum States {
		start,
		forest,
		beach,
		path,
		river,
		boat,
		cave,
		leave
	};
	public States myState;

	public bool tape;
	public bool rope;
	public bool food;

	// Use this for initialization
	void Start() {
		myState = States.start;
		tape = false;
		rope = false;
		food = false; 
	}

	// Update is called once per frame
	void Update() {
		if (myState == States.start) {
			State_start();
		} else if (myState == States.forest) {
			State_forest();
		} else if (myState == States.beach) {
			State_beach();

		} else if (myState == States.path) {
			State_path();
		} else if (myState == States.river) {
			State_river();
		} else if (myState == States.boat) {
			State_boat();
		} else if (myState == States.cave) {
			State_cave();
		} else if (myState == States.leave) {
			State_leave();
		}
	}

	void State_start() {
		textobject.text = "You wake up on a small island" +
			"\nYou can go to the forest" +
			"\nYou can stay at the beach" +
			"\n\nPress A to go to the Forest. Press D to go to the Beach";
		

		if (Input.GetKeyDown(KeyCode.A)) {
			myState = States.forest;

		} else if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.beach;
		}
	}


	void State_forest() {
		textobject.text = "You can go follow a dirt path" +
		"\nYou can follow the river" +
		"\n\nPress A to go follow the path. Press D to go follow the river" +
		"\nPress W to go to the beach.";
		if (Input.GetKeyDown (KeyCode.A)) {
			myState = States.path;
		} else if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.river;
	
		} else if (Input.GetKeyDown (KeyCode.W)) {
			myState = States.beach;
		}
	}



	void State_beach() {
		textobject.text = "You see a cave to the right, and a boat to your left." +
			"\n\nPress A to examine Boat. Press D to go to the cave." +
			"\nPress W to go to the forest.";
		if (Input.GetKeyDown(KeyCode.A)) {
			myState = States.boat;
		} else if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.cave;
		} else if (Input.GetKeyDown(KeyCode.W)) {
			myState = States.forest;
		}
	}
	void State_path() {
		//Console.WriteLine("Path");
		//if (tape == false) {
			textobject.text = "You find some tape." +
				"\nYou can head back to camp or keep searching for supplies" +
				"\n\nPress A to go back to the beach. Press D to keep searching";
			tape = true;
			if (Input.GetKeyDown(KeyCode.A)) {
				myState = States.beach;
			} else if (Input.GetKeyDown(KeyCode.D)) {
				myState = States.river;
			}

			
		}




	void State_river() {
		textobject.text = "You find water and food." +
		"\nGo back to camp or keep searching" +
		"\n\nPress A to go to the beach. Press D to keep searching";

		food = true;
		if (Input.GetKeyDown(KeyCode.A)) {
			myState = States.beach;
		}
		else if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.path;
		
		}
	}
	void State_boat() {
		if (tape == false && rope == false) {
			textobject.text = "The boat is broken. You need something to repair the holes." +
			"\nYou also need to find some rope for the sails." +
			"\n\n Press A to go back to the beach";
			if (Input.GetKeyDown (KeyCode.A)) {
				myState = States.beach;
			}
		} else if (tape == true && rope == false) {
			textobject.text = "You have tape. " +
			"\nYou still need rope to fix the boat." +
			"\n\n Press A to go back to the beach";
			if (Input.GetKeyDown (KeyCode.A)) {
				myState = States.beach;
			}
		} else if (tape == false && rope == true) {
			textobject.text = "You have Rope." +
			"\nYou need tape to fix the boat." +
			"\n\nPress A to go back to the beach.";
			if (Input.GetKeyDown (KeyCode.A)) {
				myState = States.beach;
			}
		} else if (tape == true && rope == true) {
			textobject.text = "You fixed the boat." +
			"\nPress A to leave the island. Press D to go back to the beach";
			if (Input.GetKeyDown (KeyCode.D)) {
				myState = States.beach;
			} else if (Input.GetKeyDown (KeyCode.A)) {
				myState = States.leave;
			}
		}

	}

	void State_cave() {
		textobject.text = "You find some rope." +
			"\n\nPress A to go back to the beach";
		rope = true; 
		if (Input.GetKeyDown(KeyCode.A)) {
			myState = States.beach;
		}
	}
	void State_leave() {
		if (food == true) {
		textobject.text = "You got off the island and return to civilization safely." +
			"\n\n You win!";
		} else if (food == false){
				textobject.text = "You died of starvation at sea." +
					"\n\nYou lose.";
			}
			
		}

}
