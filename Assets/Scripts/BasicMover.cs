using UnityEngine;
using System.Collections;

public class BasicMover : MonoBehaviour {
	
	// degrees/s
	public float spinSpeed = 180.0f; 
	public float motionMagnitude = 0.1f;

	// Update is called once per frame
	void Update () {
		// Rotates around the up axis
		gameObject.transform.Rotate (Vector3.up * spinSpeed * Time.deltaTime);

		// Move up and down over time
		gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
	}
}
