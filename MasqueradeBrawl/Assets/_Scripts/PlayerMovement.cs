using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public GameObject Character;
    //Rigidbody2D rb;
    //SpriteRenderer sr;
    public float speed;
    public float Maxspeed;
    //bool Flipped;

	void Start () {
        //rb = Character.GetComponent<Rigidbody2D>();
        //sr = Character.GetComponent<SpriteRenderer>();
	}
	void FixedUpdate()
    {
        transform.Translate(new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0,0));
        //rb.AddForce(new Vector3(translation * Time.deltaTime, 0, 0));

        //rb.velocity = Vector3.ClampMagnitude(rb.velocity, Maxspeed);

        //if (Flipped == true)
        //{
        //    WSTrans.transform.localPosition = new Vector2(0.007f, -0.32f);
        //    WSsr.flipY = true;

        //}
        //else if (Flipped == false)
        //{
        //    WSTrans.transform.localPosition = new Vector2(0.007f, 0.32f);
        //    WSsr.flipY = false;
        //}

    }
	
	
}
