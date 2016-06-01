using UnityEngine;
using System.Collections;

public class newsc : MonoBehaviour {

	// class 3 plan...
	// create create boundary...

	// moving stuff
	public float speed = 0.1f;
	public float rightLimit = 8.169991f; 
	public float leftLimit = -8.03f;


	// shooting stuff.
	// location... 
	public Transform shotSpawn;	
	// the firing prefab... 
	public GameObject shot;

	// timing...
	public float fireRate = 2; 
	private float nextFire; 


	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("up")){
			transform.Translate(0.0f, speed, 0.0f);
		}
		if (Input.GetKey("down")){
			transform.Translate(0.0f, -speed, 0.0f);
		}
		if (Input.GetKey("left")){
			transform.Translate(-speed, 0.0f, 0.0f);
		}
		if (Input.GetKey("right")){
			transform.Translate(speed, 0.0f, 0.0f);
		}

		//------>>> boundary code.... 

		if (transform.position.x <= leftLimit) {
			// then we set the position back... 
			transform.position = new Vector3(leftLimit, transform.position.y, transform.position.z);
		}


		if (transform.position.x >= rightLimit) {
			// then we set the position back... 
			transform.position = new Vector3(rightLimit, transform.position.y, transform.position.z);

		}
		// ---> homework do the rightside... 

		// ---> homework... make it so that the shot fires everytime you press space...
		//Instantiate (shot , shotSpawn.position ,shotSpawn.rotation); 
										// this is the answer to homework...
		if  (Time.time > nextFire && Input.GetKeyDown("space")) {
			nextFire = Time.time + fireRate; 	
			Instantiate (shot , shotSpawn.position ,shotSpawn.rotation); 

		}

		//---> thomas copy this part/// 

		if (Input.GetKeyDown ("space")) {
			Instantiate (shot, transform.position, Quaternion.identity);	
		}



		///






	}
}
