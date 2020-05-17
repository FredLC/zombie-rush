using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObject : MonoBehaviour {

	[SerializeField] private float objectSpeed = 1;
	private float resetPosition = -37f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.left * (objectSpeed * Time.deltaTime));

		if (transform.localPosition.x <= resetPosition) {
			Vector3 newPosition = new Vector3(60f, 0.1335754f, 70f);
			transform.position = newPosition;
		}
	}
}
