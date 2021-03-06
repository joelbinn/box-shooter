﻿using UnityEngine;
using System.Collections;

public class BasicTargetMover : MonoBehaviour {
	
	// degrees/s
	public bool doSpin = true;
	public float spinSpeed = 180.0f; 

	public bool doMotion = false;
	public float motionMagnitude = 0.1f;


	// Update is called once per frame
	void Update () {
		if (doSpin) {
			// Rotates around the up axis
			gameObject.transform.Rotate (Vector3.up * spinSpeed * Time.deltaTime);
		}

		if (doMotion) {
			// Move up and down over time
			gameObject.transform.Translate (Vector3.up * Mathf.Cos (Time.timeSinceLevelLoad) * motionMagnitude);
		}
	}
}
