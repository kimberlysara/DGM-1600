using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public static GameObject player;
	public static LevelManager manager;


	void Start() {
		manager = this;
		print ("Manager");
		print (manager);
	}


	public void LevelLoad (string name) {

		SceneManager.LoadScene (name);
	}
		
	public void ExitGame (){
		print ("Tried to Exit");
		Application.Quit ();
	}
	public void LoadNextLevel () {
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	}

		
			

		}	

