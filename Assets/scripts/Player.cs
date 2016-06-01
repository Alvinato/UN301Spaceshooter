using UnityEngine;
using System.Collections;


/*[System.Serializable]
public class Boundary 
{
	public float xMin, xMax, yMin, yMax; //Screen Boundary dimentions
}*/

public class Player : MonoBehaviour {
	
	// variable controlling the speed...
	public float speed = 2f;
	public Boundary boundary; 		//make an Object from Class Boundary
	public GameObject shot;			//Fire Prefab
	public Transform shotSpawn;		//Where the Fire Spawn
	// Use this for initialization
	void Start () {
		
	}


	// ---> this is probably enough... 
	// Update is called once per frame
	void Update () {
		// teach this first...
	/*	if (Input.GetKey("up")){
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
		}*/

		// here we are going to get the shot to fire properly... 
		//Excute When the Current Time is bigger than the nextFire time
		//if (Time.time > nextFire) 
		//{
	//		nextFire = Time.time + fireRate; 								//Increment nextFire time with the current system time + fireRate
			Instantiate (shot , shotSpawn.position ,shotSpawn.rotation); 	//Instantiate fire shot 
	//		GetComponent<AudioSource>().Play (); 													//Play Fire sound
	//	}

	}

	// explain fixedupdate... This is the same as update however fixed update runs before update... so movement is better and more 
	// smooth... it repeats at a constant time where as update moves according to the frame...
	void FixedUpdate () { 
		// gathers keyboard input from the left and the right keys... it returns 1 or -1
		// it makes it more realistic by giving gradual values...
		float moveHorizontal = Input.GetAxis ("Horizontal"); 				//Get if Any Horizontal Keys pressed
		//Debug.Log(moveHorizontal);
		float moveVertical = Input.GetAxis ("Vertical");					//Get if Any Vertical Keys pressed
		// we create a vector2 value that has the directional magnitude.
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical); 		//Put them in a Vector2 Variable (x,y)
		// we multiply that by the speed that we have set...
		GetComponent<Rigidbody2D>().velocity = movement * speed; 							//Add Velocity to the player ship rigidbody

		// lets have the piece of code that checks the boundaries... not with mine though..

		//if (transform.position < boundary.xMin) {
			// then we reset the position
			// we need script that is the same as the kids script...
		//}

		//Lock the position in the screen by putting a boundaries
		//GetComponent<Rigidbody2D>().position = new Vector2 
		//	(
				// ensures that the position is within our boundary.
				// if we have set our x to be past our boundary then it will set x back... 
				// if our position is within the boundaries it will stay the same
				// we clamp the x 
		//		Mathf.Clamp (GetComponent<Rigidbody2D>().position.x, boundary.xMin, boundary.xMax),  //X
				// we clamp the y
		//		Mathf.Clamp (GetComponent<Rigidbody2D>().position.y, boundary.yMin, boundary.yMax)	 //Y
		//	);
	}

	//---> we need an ontrigger event here...
	// right now it just deletes it but we are going to do something different later.
	void OnTriggerEnter2D(Collider2D other){
		Debug.Log (other);
		//if (other.ToString () == "shot(Clone)") {
	//		return;
//		}
//		Destroy (gameObject);
	
	}
	void OnCollisionEnter2D(Collision2D coll) {
	
	
	
	
	}
}
