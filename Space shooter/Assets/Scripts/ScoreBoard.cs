using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour {
	public int score;
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
			highscoreDisplay.text = GetScore ().ToString ();
		}
		if (prevsScoreDisplay != null)
			prevsScoreDisplay.text = PlayerPrefs.GetInt ("PrevsScore").ToString ();
	}
	
	public void IncrementScoreBoard(int value){
		score += value;
		display.text = score.ToString ();
}
	public void SaveScore(){
		//Check Prevoius score
		int oldScore = GetScore();
		PlayerPrefs.SetInt ("PrevsScore", oldScore);

		//if new score is higher
		if (score > oldScore) {
			PlayerPrefs.SetInt ("HighScore", score);
		}
	}
	public int GetScore(){
		return PlayerPrefs.GetInt ("HighScore");
	
	}
	public void OnDisable(){
		SaveScore ();
	}
}
