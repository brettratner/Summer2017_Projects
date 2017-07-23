using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class TimePowerup : MonoBehaviour {
	public float timeAmount = 5;
	// Use this for initialization
	void Start () {
		//public AudioSource Audio;

	}
	
	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == ("Player1")) { // checks to see if object collides with player 1.

			Destroy (this.gameObject); //Destroys itslef after collision.
			Timer.timer = Timer.timer - timeAmount; // subracts a variable amount of time.
			//Audio.Play ();

		}
		if (col.gameObject.tag == ("Player2")) { // checks to see if object collides with player 1.

			Destroy (this.gameObject); //Destroys itslef after collision.
			Timer.timer = Timer.timer + timeAmount; // adds a variable amount of time.
			//Audio.Play ();

		}


	}

}
