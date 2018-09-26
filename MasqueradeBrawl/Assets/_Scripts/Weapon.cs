using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

	public int fireRate = 0;
	public float Damage = 10;
	public string FirePointName;
	public LayerMask WhatToHit;

	public Transform Bullet;
	public Transform OnContact; 

	private float timeToFire = 0;
	Transform firePoint;


	// Use this for initialization
	void Awake () {
		firePoint = transform.Find (FirePointName);//Case sensitive
		if (firePoint == null) {
			Debug.LogError ("No firePoint found.");
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (fireRate == 0) {
			if (Input.GetButtonDown ("Fire1")) {
				Shoot ();

			}
		} else {
			if (Input.GetButtonDown ("Fire1") && Time.time > timeToFire) {
				timeToFire = Time.time + 1/fireRate;
				Shoot ();

			}
		}
	}
	void Shoot(){
		Vector2 mousePosition = new Vector2 (Camera.main.ScreenToWorldPoint (Input.mousePosition).x, Camera.main.ScreenToWorldPoint (Input.mousePosition).y); //Supposedly binds firepoint to screen/mouse aspect:ratio...
		Vector2 firePointPosition = new Vector2 (firePoint.position.x, firePoint.position.y);
		RaycastHit2D hit = Physics2D.Raycast (firePointPosition, mousePosition-firePointPosition,100,WhatToHit);
		Effect ();
		//Debug.DrawLine (firePointPosition, (mousePosition-firePointPosition)*50, Color.cyan);
		if (hit.collider != null) {
			Instantiate (OnContact, hit.point,firePoint.rotation);

			Debug.Log (hit.collider.name + " has taken " + Damage + " damage.");
		}
	}

	void Effect(){
		Instantiate (Bullet, firePoint.position,firePoint.rotation);//Grabs what bullet to use and placeses at the fire point.
		//Debug.Log (firePoint.rotation);

	}

}



