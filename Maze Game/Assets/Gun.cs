using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

	public float damage = 10f;
	public float range = 100f;
	public float impactForce = 100f;
	public float fireRate;

	public Camera fpsCam;
	public ParticleSystem muzzleFlash;
	public GameObject impactEffect;

	private float nextTimeToFire = 1f;

	void Start (){
		fireRate = 4f; //sets the firerate to 4
	}

	// Update is called once per frame
	void Update () {
		
		if (Input.GetButtonDown ("Fire1") && Time.time >= nextTimeToFire) { //change GetButtonDown -> GetButton to enable continious shooting
			nextTimeToFire = Time.time + 1f / fireRate; // sets the next time to fire bassed on fire rate. Higher firerate quicker next time to fire
			//Debug.Log ("Next Fire2: " +nextTimeToFire);
			Shoot ();
		}
	}

	void Shoot (){
		muzzleFlash.Play();
		RaycastHit hit;
		if (Physics.Raycast (fpsCam.transform.position, fpsCam.transform.forward, out hit)) { //returns true when player shoots and stores all info about raycast in hit
			Debug.Log (hit.transform.name);//logs whats the "bullet" hits


			Target target = hit.transform.GetComponent<Target> ();
			if (target != null) { //checks to make sure the object being hit has a target, if yes that object will take damage, if no then do nothing.
				target.TakeDamage(damage);
			}

			if (hit.rigidbody != null) { // checks to see if the object that is hit has a rigidbode, if yes add knockback, if no do nothing.
				hit.rigidbody.AddForce(hit.normal * impactForce);
			}
			GameObject impactGO = Instantiate (impactEffect, hit.point, Quaternion.LookRotation (hit.normal)); //creates the impact effect on objet that was hit.
			Destroy (impactGO, .05f); // the .05 means the bullet will dissapear in .05 seconds
		}
	}
}
