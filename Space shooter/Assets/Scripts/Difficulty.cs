using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour {
	public static int maxMeteors = 15;
	//public GameObject scoreBoard;
	private static int lastScoreUpgrade = 0;
	public GameObject asteroidField;
	public AsteroidField asteroidFieldInstance;
//public ScoreBoard scoreInstance;

	// Use this for initialization
	void Start () {
		asteroidFieldInstance = GetComponent<AsteroidField> ();
		//scoreInstance = GetComponent<ScoreBoard>();
	}
	
	// Update is called once per frame
	void Update () {
		if (ScoreBoard.score >= 100 && ScoreBoard.score > lastScoreUpgrade) {
			maxMeteors = 100;
			lastScoreUpgrade = 100;
			asteroidFieldInstance.spawnRate = 0.8f;
		}
		if (ScoreBoard.score >= 200 && ScoreBoard.score > lastScoreUpgrade) {
			maxMeteors = 100;
			lastScoreUpgrade = 200;
			asteroidFieldInstance.spawnRate = 0.6f;
		}
		if (ScoreBoard.score >= 300 && ScoreBoard.score > lastScoreUpgrade) {
			maxMeteors = 100;
			lastScoreUpgrade = 300;
			asteroidFieldInstance.spawnRate = 0.4f;
		}
		if (ScoreBoard.score >= 400 && ScoreBoard.score > lastScoreUpgrade) {
			maxMeteors = 100;
			lastScoreUpgrade = 400;
			asteroidFieldInstance.spawnRate = 0.2f;
		}
		if (ScoreBoard.score >= 500 && ScoreBoard.score > lastScoreUpgrade) {
			maxMeteors = 100;
			lastScoreUpgrade = 500;
			asteroidFieldInstance.spawnRate = 0.1f;
		}
	}

}
