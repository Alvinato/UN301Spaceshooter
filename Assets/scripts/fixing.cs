
using UnityEngine;
using System.Collections;

public class fixing : MonoBehaviour {

	public float speed = 5.0f;
	public int rightlimit = 100;
	public int leftlimit = 100;
	private Rigidbody2D body;

	public Transform shotSpawn;
	public GameObject shot;

	public float firerate = 1;
	private float nextfire;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		float horizontalmovement = Input.GetAxis ("Horizontal");
		float verticalmovement = Input.GetAxis ("Vertical");
		//body.velocity = new Vector2 (movement * speed, body.velocity.y);
		transform.position = transform.position + new Vector3(horizontalmovement * speed, verticalmovement * speed, 0.0f);

		if (transform.position.x >= leftlimit)
		if (transform.position.x >= rightlimit) {
			transform.position = new Vector3 (leftlimit, 0.0f, 0.0f);
			transform.position = new Vector3 (rightlimit, 0.0f, 0.0f);



		}
		if (Time.time > nextfire) {
			nextfire = Time.time + firerate;
			Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
		}
	}
		
}