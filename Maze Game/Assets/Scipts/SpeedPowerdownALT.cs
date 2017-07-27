using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerdownALT : MonoBehaviour {
	public static float Multiplyer = 0.5f;    // defines what amount we will decreese the players speed by
	public float  P1Speed;
	public float  P2Speed;

	public static bool playerOneGot;  //if true then player one got the item
	public static bool playerTwoGot;  // if true then player two got the item
	public float speedTimeout = 10;


	void Update () {

		if (playerOneGot) {
			
			speedTimeout -= Time.deltaTime;

			if(speedTimeout < 0)
			{
				Debug.Log ("speed time out : " + speedTimeout);
				SpeedPowerdown.playerOneGot = false;
				this.gameObject.GetComponent<Renderer>().enabled = true;		
				speedTimeout = 10;
				PlayerMove.P2speed = PlayerMove.P2speed / Multiplyer;	
				this.gameObject.transform.Translate (0f, 3f, 0f);
				playerOneGot = false;

			}
		}

		if (playerTwoGot) {
		//	Debug.Log ("player 2 variable set to true"+ speedTimeout);

			speedTimeout -= Time.deltaTime;

			if(speedTimeout < 0)
			{
//				Debug.Log ("speed time out : " + speedTimeout);
				SpeedPowerdown.playerTwoGot = false;
				this.gameObject.GetComponent<Renderer>().enabled = true;		
				speedTimeout = 10;
				PlayerMove.P1speed = PlayerMove.P1speed / Multiplyer;	
				this.gameObject.transform.Translate (0f, 3f, 0f);
				playerTwoGot = false;

			}
		}
	}
	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == ("Player1")) {  //detects if the object that collided with it had a tag of player1
			playerOneGot = true;  				 //activates that player one got the item
			this.gameObject.GetComponent<Renderer>().enabled = false;	
			this.gameObject.transform.Translate (0f, -3.0f, 0f);
			PlayerMove.P2speed = PlayerMove.P2speed * Multiplyer;
		}
		if (col.gameObject.tag == ("Player2")) {
			playerTwoGot = true;
			this.gameObject.transform.Translate (0f, -3.0f, 0f);
			this.gameObject.GetComponent<Renderer>().enabled = false;		
			PlayerMove.P1speed = PlayerMove.P1speed * Multiplyer;
		}

	}


}
