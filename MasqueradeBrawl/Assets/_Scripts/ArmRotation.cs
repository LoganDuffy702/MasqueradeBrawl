using UnityEngine;
using System.Collections;

public class ArmRotation : MonoBehaviour {

	public float rotationOffset = 0;
	// Update is called once per frame
	private SpriteRenderer sr; 
	//private Transform objectPostion;

	void Start(){
		sr = GetComponent<SpriteRenderer> ();
		//objectPostion = GetComponent<Transform> ();
	}
	void Update () {
		//subrating the position of the player from the mouse position
		Vector3 difference = Camera.main.ScreenToWorldPoint (Input.mousePosition) - transform.position;
		Vector3 MousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);

		difference.Normalize ();//normalizing the vector. Meaning that all the sum of the vector will be == to 1

		if (sr.flipX == false) {
			float rotZ = Mathf.Atan2 (difference.y, difference.x) * Mathf.Rad2Deg; //finding the angle in degrees
			transform.rotation = Quaternion.Euler (0f, 0f, rotZ + rotationOffset);
		}
		else if (sr.flipX == true) {
			float rotZ = Mathf.Atan2 (difference.y, difference.x) * Mathf.Rad2Deg; //finding the angle in degrees
			transform.rotation = Quaternion.Euler (0f, 0f, rotZ + rotationOffset);
		}

		if (MousePos.x <= (transform.position.x)) {
			sr.flipY = true;
			sr.flipX = false;

		}
		else if (MousePos.x >= (transform.position.x)) {
			sr.flipY = false;//change to y...
		}



	}
}
