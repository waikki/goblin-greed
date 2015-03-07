using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
	public float speed = 1;
	public Transform[] cameraPoints;
	Vector3 direction;
	int pointNumber;
	
	// Update is called once per frame
	void Update () {

		//etsitään vektorien välinen suunta kun ollaan tarpeeksi lähellä seuraavaa käännöspistettä
		if (Vector3.Distance(transform.position, cameraPoints[pointNumber].position) <= 0.5f) {
			direction = cameraPoints[pointNumber+1].position - cameraPoints[pointNumber].position;
			direction.Normalize();
			pointNumber++;
		}
	
		//liikutaan haluttuun suuntaan
		transform.position += direction * Time.deltaTime * speed;

		// kun saavutetaan viimeinen piste, pysäytetään kamera
		if (Vector3.Distance(transform.position, cameraPoints[cameraPoints.Length - 1].position) <= 0.1f) {
		    Destroy(this);
		}
	}
}