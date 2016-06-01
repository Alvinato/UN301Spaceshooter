using UnityEngine;
using System.Collections;

public class animationscript : MonoBehaviour {

	// this is going to hold the animation clip

	public AnimationClip explosion;
	private float TimeofClip;
	private float Endtime;


	void Start () {
		TimeofClip = explosion.length;  // gets the length of the clip..
		// gets the time of when it is supposed to end... 
		Endtime = Time.time + TimeofClip;
	}
	
	// Update is called once per frame
	void Update () {
	// checck if the animation in this script has ended... if it has then destroy it... 
	// 
		if(Time.time >= Endtime){
			// this is going to destroy the game object...
			Destroy (gameObject);
		}

	}
}
