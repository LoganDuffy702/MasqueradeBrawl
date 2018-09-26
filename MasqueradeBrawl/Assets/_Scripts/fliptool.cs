using UnityEngine;
using System.Collections;

public class fliptool : MonoBehaviour {

	//bool facingRight = true;

	private SpriteRenderer sr;
	// Use this for initialization
	void Start () {
		sr = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.D)) {
			transform.localPosition = (new Vector2(0.43f,1.04f));
			sr.flipX = false;

		}

		if (Input.GetKey(KeyCode.A)) {
			transform.localPosition = (new Vector2(-0.48f,1.04f));
			sr.flipX = true;

		}
	}
}
