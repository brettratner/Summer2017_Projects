using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour {
	private Rigidbody rb; 
	public GameObject Player1, Player2;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {
		if (this.gameObject.transform.position.y < -5.0f && this.gameObject == Player1) {
			Debug.Log ("the game object name is: " + this.gameObject);
			Player1.transform.position = new Vector3 (1.0f, 0.5f, 0.0f);
			rb.isKinematic = true;
		} else {
		
				rb.isKinematic = false;

			   }
		if (this.gameObject.transform.position.y < -5.0f && this.gameObject == Player2) {

			Player2.transform.position = new Vector3 (10.0f, 0.5f, 0.0f);
			rb.isKinematic = true;
		} else {

			rb.isKinematic = false;

		}
	}
}
