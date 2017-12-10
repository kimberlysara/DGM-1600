using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour {
	public static int score = 0;
	public Text display;
	public Text highscoreDisplay;
	public Text prevsScoreDisplay;
	// Use this for initialization
	void Start () {
		score = 0;
		if (display != null) {
			display.text = score.ToString ();
		}
		if (highscoreDisplay != null) {
			highscoreDisplay.text = GetHighScore ().ToString ();
		}
		if (prevsScoreDisplay != null) {
			prevsScoreDisplay.text = score.ToString ();
		}
	}
	
	public static void AddPoints(int value){
		score += value;
		print ("Score: " + score.ToString ());
	}

	void Update() {
		if (display != null) {
			display.text = score.ToString ();
		}
		if (highscoreDisplay != null) {
			highscoreDisplay.text = GetHighScore ().ToString ();
		}
		if (prevsScoreDisplay != null) {
			prevsScoreDisplay.text = score.ToString ();
		}
	}

	public void SaveScore(){
		//Check Prevoius score
		int highScore = GetHighScore();
		PlayerPrefs.SetInt ("PrevsScore", score);

		//if new score is higher
		if (score > highScore) {
			PlayerPrefs.SetInt ("HighScore", score);
		}
	}
	public int GetHighScore(){
		return PlayerPrefs.GetInt ("HighScore");
	
	}
	public void OnDisable(){
		SaveScore ();
	}
}
