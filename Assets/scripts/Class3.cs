using UnityEngine;
using System.Collections;

public class Class3 : MonoBehaviour {


	// moving stuff
	public float speed = 0.1f;
	public float rightLimit = 8.8f; 
	public float leftLimit = -8.8f;
	public float verticaltopLimit = 0f; 
	public float verticalbottomLimit = -4.5f;

	// shooting stuff.
	// location... 
	public Transform shotSpawn;	
	// the firing prefab... 
	public GameObject shot;		
	// Use this for initialization

	// timing...
	public float fireRate = 20; 
	private float nextFire; 


	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Instantiate (shot , shotSpawn.position ,shotSpawn.rotation); 

		float moveHorizontal = Input.GetAxis ("Horizontal"); 				//Get if Any Horizontal Keys pressed

		float moveVertical = Input.GetAxis ("Vertical");					//Get if Any Vertical Keys pressed

		Vector2 movement = new Vector2 (moveHorizontal, moveVertical); 		//Put them in a Vector2 Variable (x,y)

		GetComponent<Rigidbody2D>().velocity = movement * speed; 	


		// boundaries//---->>   need to refactor this...

		if (transform.position.x <= leftLimit) {
			// then we set the position back... 
			transform.position = new Vector3(leftLimit, transform.position.y, transform.position.z);

		}
			
		if (transform.position.x >= rightLimit) {
			// then we set the position back... 
			transform.position = new Vector3(rightLimit, transform.position.y, transform.position.z);

		}
		if (transform.position.y  >= verticaltopLimit) {
			// then we set the position back... 
			transform.position = new Vector3(transform.position.x, verticaltopLimit, transform.position.z);

		}

		if (transform.position.y <= verticalbottomLimit) {
			// then we set the position back... 
			transform.position = new Vector3(transform.position.x, verticalbottomLimit, transform.position.z);

		}

		// Homework... make it so that it shoots everytime you press a button...
		if  (Time.time > nextFire && Input.GetKeyDown("space")) {
			nextFire = Time.time + fireRate; 	
			Instantiate (shot , shotSpawn.position ,shotSpawn.rotation); 

			}


		// delete the bullet now that it is firing...

		// ---> 

	}
}
