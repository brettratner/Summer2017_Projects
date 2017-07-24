using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {
	
	public bool switch1Pressed = false;

	public GameObject switch1;

	private bool switch1on = false;

	public double counter1;

	public GameObject wall_1;
	public GameObject wall_2;

	public float switchTimeout1 = 5;
	void Awake(){
		switch1.SetActive (true);
		wall_2.SetActive (false);
	}
	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		counter1 = 1;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (switch1Pressed == true) {
			if ((counter1 % 2) == 0) {
				//walls that are already visible
				wall_1.SetActive (switch1on);
				//walls that are invisible 
				wall_2.SetActive (!switch1on);
			}
			else if((counter1 % 2) == 1 ){
				//walls that are already visible
				wall_1.SetActive (!switch1on);
				//walls that are invisible 
				wall_2.SetActive (switch1on);
			}
			switchTimeout1 -= Time.deltaTime;
			if(switchTimeout1 < 0)
			{
				switch1Pressed = false;
				switch1.SetActive (true);
				switchTimeout1 = 5;
			}
		}
	}
	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == ("switch1")) {
			switch1Pressed = true;
			counter1 = counter1 + 1;
			switch1.SetActive (false);


		}
			

	}
}
