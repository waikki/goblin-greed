using UnityEngine;
using System.Collections;

public class CoinCounter : MonoBehaviour {

	public static int coinCount = 0;

	void Start() {
		coinCount = 0;
	}

	void OnGUI() {

		string coinText = "Coins: " + coinCount + " / 6";
		GUI.Box(new Rect(Screen.width-150, 20, 130, 20), coinText);
	}
}
