using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	// Use this for initialization
	//public GameObject Player; 
	public GameObject Asteroid;
	public int waveNumber = 5;
	public float waveRate = 2; 
	private float nextFire; 

	// keeps score of our game.
	public int score = 0;
	// the text object in our game. 
	public GUIText scoreText;



	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time >= nextFire) {
			nextFire = Time.time + waveRate;
			Vector3 position = new Vector3(Random.Range(-7.23f, 7.23f), 4.13f, 1f); 
			Instantiate (Asteroid, position, Quaternion.identity);
			waveNumber = waveNumber - 1;
		}

		if (waveNumber <= 0) {
			// then this round is won and we end game!! 


		}
		 

	}

	public void AddScore (int newScoreValue){

		// add score was called 

		Debug.Log ("add score was called!!");

		score += newScoreValue; // updates the score...
		UpdateScore ();  // updates the text
	
	}

	void UpdateScore(){ 
		scoreText.text = "Score:" + score;
	}
}
