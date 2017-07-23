using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerdown : MonoBehaviour {
	public float Multiplyer = 0.01f;
	public float  P1Speed;
	public float  P2Speed;


	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == ("Player1")) {
			//Destroy(this.gameObject);
			this.gameObject.SetActive(false);
			PlayerMove.P2speed = PlayerMove.P2speed * Multiplyer;

		}
		if (col.gameObject.tag == ("Player2")) {
			//Destroy (this.gameObject);
			this.gameObject.SetActive(false);
			PlayerMove.P1speed = PlayerMove.P1speed * Multiplyer;

		}

	}
}
