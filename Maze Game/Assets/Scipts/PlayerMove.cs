using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
	[SerializeField]
	private Rigidbody rb; 
	public static float P1speed;
	public static float P2speed;
	public string horzMov = "Horizontal";
	public string vertMov = "Vertical";

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		if (gameObject.tag == ("Player1")) {
			P1speed = 10f;

		}
		if(gameObject.tag==("Player2")){
			P2speed = 10f;
		}


			
	}
	
	// Update is called once per frame
	void Update () {
		float moveHorizontal = Input.GetAxis (horzMov);
		float moveVertical = Input.GetAxis (vertMov);
	//	Debug.Log ("Speed1 is: " + P1speed);
    //	Debug.Log ("Speed2 is: " + P2speed);

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);


		if (gameObject.tag == ("Player1")) {
			rb.AddForce (movement * P1speed);
		}
		if(gameObject.tag==("Player2")){
			rb.AddForce (movement * P2speed);
		}
			
	}
}

