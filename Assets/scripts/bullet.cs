using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {

	public GameController gameController;
	public float speed = 0.5f; //Speed of the velocity

	// Use this for initialization
	void Start () {
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");

		gameController = gameControllerObject.GetComponent<GameController> ();

	}
	
	// Update is called once per frame
	void Update () {
	
		//GetComponent<Rigidbody2D>().velocity = transform.up * speed; //Give Velocity to the Player ship shot
		transform.Translate(0.0f, speed, 0.0f);

		// this destroys the bullet...
		if (transform.position.x >= 2.56f) {
			Destroy (gameObject);
		}

	}


	// we can just say that as soon as it leaves a certain place then delete it... 

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log("this is running");
		if (other.tag == "Asteroid") {
			//Destroy (other.gameObject);
			///Destroy (gameObject);
			// we should create an explosion here... 
			Debug.Log("hit an asteroid!");
			// we should count a point here...
			gameController.AddScore(1);


		}
			
			

	}
}