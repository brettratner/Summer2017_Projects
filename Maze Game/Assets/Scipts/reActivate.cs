using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reActivate : MonoBehaviour {

	public float PowerDownspeedTimeout = 10;

	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		SpeedPowerdown.playerOneGot = false;
		SpeedPowerdown.playerTwoGot = false;
		this.gameObject.SetActive (true);
	}

	
	// Update is called once per frame
	void Update () {
		
		if (SpeedPowerdown.playerOneGot) {
			Debug.Log ("player 1 variable set to true"+ PowerDownspeedTimeout);

			PowerDownspeedTimeout -= Time.deltaTime;

			if(PowerDownspeedTimeout < 0)
			{
				Debug.Log ("speed time out : " + PowerDownspeedTimeout);
				SpeedPowerdown.playerOneGot = false;
				SpeedPowerdown.powerdown1.SetActive (true);
				PowerDownspeedTimeout = 10;
				PlayerMove.P2speed = PlayerMove.P2speed / SpeedPowerdown.Multiplyer;
				SpeedPowerdown.playerOneGot = false;
			}
		}

		if (SpeedPowerdown.playerTwoGot) {
			Debug.Log ("player 2 variable set to true"+ PowerDownspeedTimeout);

			PowerDownspeedTimeout -= Time.deltaTime;

			if(PowerDownspeedTimeout < 0)
			{
				Debug.Log ("speed time out : " + PowerDownspeedTimeout);
				SpeedPowerdown.playerTwoGot = false;
				SpeedPowerdown.powerdown1.SetActive (true);
				PowerDownspeedTimeout = 10;
				PlayerMove.P1speed = PlayerMove.P1speed / SpeedPowerdown.Multiplyer;	
				SpeedPowerdown.playerTwoGot = false;
			}
		}
	}
}
