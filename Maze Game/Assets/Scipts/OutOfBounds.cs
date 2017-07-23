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
		if (this.gameObject.transform.position.y <= -5.0f) {
			
			Player1.transform.position = new Vector3 (4.0f, 0.5f, 0.0f);
			Player2.transform.position = new Vector3 (7.0f, 0.5f, 0.0f);
			rb.isKinematic = true;
			Debug.Log (this.gameObject.transform.position);
		} else {rb.isKinematic = false;
		}
	}
}
