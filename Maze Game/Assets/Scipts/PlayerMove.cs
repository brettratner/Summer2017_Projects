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
		if (gameObject.tag == ("Player1")) {  //checks to see if the object has a tag of Player1
			P1speed = 10f;					 // sets speed player 1 to 10mph

		}
		if(gameObject.tag==("Player2")){      //checks to see if the object has a tag of Player1
			P2speed = 10f;					 // sets player 2 speed to 10mph
		}


			
	}
	
	// Update is called once per frame
	void Update () {
		float moveHorizontal = Input.GetAxis (horzMov); // Sets the left/right movement to the input of Horizontal
		float moveVertical = Input.GetAxis (vertMov);   // Sets the foward/backward movement to the input of Vertical
		Debug.Log ("Speed1 is: " + P1speed);
    	Debug.Log ("Speed2 is: " + P2speed);

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical); 


		if (gameObject.tag == ("Player1")) {
			rb.AddForce (movement * P1speed);  //allows player 1 to move
		}
		if(gameObject.tag==("Player2")){
			rb.AddForce (movement * P2speed);  //allows player 2 to move
		}
			
	}
}

