using UnityEngine;
using System.Collections;

public class Ending : MonoBehaviour {

	void OnTriggerEnter(Collider collider) {
		if (collider.tag == "Player") {
			Debug.Log("Collided with " + collider.name);
			Application.LoadLevel (Application.loadedLevel);
		}
	}
}
