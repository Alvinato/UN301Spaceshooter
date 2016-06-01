using UnityEngine;
using System.Collections;

public class boundary : MonoBehaviour {

	void OnTriggerExit(Collider other) {
		// Destroy everything that leaves the trigger
		Debug.Log("this is runing");
		Destroy(other.gameObject);
	}
}