using UnityEngine;
using System.Collections;

public class rock : MonoBehaviour {

	// the explosion we created.
	public GameObject explosion;
	public float speed = 4f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (0.0f, -speed, 0.0f);


	}


	void OnTriggerEnter2D(Collider2D other){

		Debug.Log ("asdfasdf");

		Destroy (gameObject);

		Debug.Log ("aasdf");
		Destroy (other.gameObject);
		Instantiate (explosion, transform.position, transform.rotation); 

	}
}
