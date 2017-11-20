using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public static int meteorCount;

	void Start(){
		meteorCount = FindObjectsOfType<Meteor> ().Length;
		print (meteorCount);
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
	public void CheckMeteorCount (){
		if (meteorCount <= 0) {
			LoadNextLevel ();
		}
	}
		}	

