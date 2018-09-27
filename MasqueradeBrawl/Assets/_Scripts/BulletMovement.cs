using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour {

	public int MoveSpeed;
	public float DestroyFade = 1;
	public GameObject OnContact; 
	// Update is called once per frame
	void FixedUpdate () {

		//Vector2 mousePosition = new Vector2 (Camera.main.ScreenToWorldPoint (Input.mousePosition).x, Camera.main.ScreenToWorldPoint (Input.mousePosition).y); //Supposedly binds firepoint to screen/mouse aspect:ratio...
		transform.Translate (Vector3.left * Time.deltaTime * MoveSpeed);
		Destroy (this.gameObject, DestroyFade);
	}

	void OnCollisionEnter2D(Collision2D col){

		if (col.gameObject.CompareTag("Walls")){
			Instantiate (OnContact, transform.localPosition,transform.localRotation);
			Destroy (gameObject);
		}
			
		

	}
	//void OnTriggerEnter2D(Collider2D other){
		//if (other.gameObject.CompareTag("Untagged")) {
			//DestroyImmediate (this.gameObject, true );
		//}
}
