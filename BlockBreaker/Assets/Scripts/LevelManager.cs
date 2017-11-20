using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public static int brickCount;
	public static Ball[] balls;

	void Update (){
	//	public void CheckBrickCount ();
		//brickCount = FindObjectsOfType<Brick> ().Length;
	}

	void Start(){
		brickCount = FindObjectsOfType<Brick> ().Length;
		print ("Number of Bricks: " + brickCount);
	}

	public void LevelLoad (string name) {
		SceneManager.LoadScene (name);
	}
		
	public void ExitGame (){
		print ("Tried to Exit");
		Application.Quit ();
	}
	public void LoadNextLevel () {
		print ("loading next level");
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
		//SceneManager.LoadScene ("Level03");

	}
	public void CheckBrickCount () {
		//brickCount = FindObjectsOfType<Brick> ().Length;
		print ("Number of Bricks: " + brickCount);
		if (brickCount <= 0) {
			LoadNextLevel();
			//LevelLoad ("Level02");
			//SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
		}
	}
}
