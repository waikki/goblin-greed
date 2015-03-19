﻿using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Time.timeScale = 0;
	}
	
	public void StartGame() {
		Time.timeScale = 1;
		Destroy (gameObject);
	}
}
