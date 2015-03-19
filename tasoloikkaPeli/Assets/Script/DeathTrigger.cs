using UnityEngine;
using System.Collections;

public class DeathTrigger : MonoBehaviour {

	void OnTriggerEnter(Collider collider) {
		if (collider.tag == "Player") {
			Debug.Log("Collided with " + collider.name);
			Application.LoadLevel (Application.loadedLevel);
		}
	}
}
