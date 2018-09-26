using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour {

	public int MoveSpeed;
	public float DestroyFade = 1;
	public Transform OnContact; 
	// Update is called once per frame
	void Update () {
		//Vector2 mousePosition = new Vector2 (Camera.main.ScreenToWorldPoint (Input.mousePosition).x, Camera.main.ScreenToWorldPoint (Input.mousePosition).y); //Supposedly binds firepoint to screen/mouse aspect:ratio...
		transform.Translate (Vector3.right * Time.deltaTime * MoveSpeed);
		Destroy (this.gameObject, DestroyFade);
	}

	void OnCollisionEnter2D(Collision2D col){

		if (col.gameObject.tag.Equals("Ground_Walls")){
			//Destroy(col.gameObject);
			Instantiate (OnContact, gameObject.transform.position,gameObject.transform.rotation);
			Destroy (this.gameObject);
		}
			
		

	}
	//void OnTriggerEnter2D(Collider2D other){
		//if (other.gameObject.CompareTag("Untagged")) {
			//DestroyImmediate (this.gameObject, true );
		//}
}
