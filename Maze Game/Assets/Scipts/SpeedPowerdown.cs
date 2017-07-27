using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerdown : MonoBehaviour {
	public static float Multiplyer = 0.5f;    // defines what amount we will decreese the players speed by
	public float  P1Speed;
	public float  P2Speed;

	public static bool playerOneGot;  //if true then player one got the item
	public static bool playerTwoGot;  // if true then player two got the item

	public static GameObject powerdown1;  // the game object that can be used by the reActive.cs script
	public  GameObject publicPowerdown1;  // the game object to be shown in inspector

	void Awake (){
		powerdown1 = publicPowerdown1;  //sets the static var to the inspector variable
	
	}
	//void Update () {Debug.Log (powerdown1);}
	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == ("Player1")) {  //detects if the object that collided with it had a tag of player1
			//Destroy(this.gameObject);
			playerOneGot = true;  				 //activates that player one got the item
			this.gameObject.SetActive(false);    // hides the powerup
			PlayerMove.P2speed = PlayerMove.P2speed * Multiplyer;

			//Debug.Log ("player 1 got object :" + playerOneGot +", " + PlayerMove.P2speed);
		}
		if (col.gameObject.tag == ("Player2")) {
			//Destroy (this.gameObject);
			playerTwoGot = true;
			this.gameObject.SetActive(false);
			PlayerMove.P1speed = PlayerMove.P1speed * Multiplyer;

			//Debug.Log ("player 1 got object :" + playerOneGot +", " + PlayerMove.P2speed);


		}

	}


}
