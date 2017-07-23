using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using TMPro;


public class Timer : MonoBehaviour {
	

	public static float timer = 120;
	public TMP_Text TimeLeft;
	 

	// Use this for initialization
	void Start () {
		Time.timeScale = 1.0f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		timer -= Time.deltaTime/2;
	}

	void OnGUI(){
		TimeLeft.text = "" + (int)timer;

	}
}
