using UnityEngine;
using System.Collections;

public class CoinPickup : MonoBehaviour {

	void OnTriggerEnter(Collider collider) {
		switch (collider.gameObject.name) {
		case "goblin" :
			CoinCounter.coinCount++;
			Destroy(this.gameObject);
			break;
		}
	}


}
