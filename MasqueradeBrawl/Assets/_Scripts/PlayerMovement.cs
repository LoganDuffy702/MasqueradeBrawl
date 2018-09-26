using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public GameObject Character;
    Rigidbody2D rb;
    SpriteRenderer sr;
    public float speed;
    public float Maxspeed;
    //bool Flipped;
	


	void Start () {
        rb = Character.GetComponent<Rigidbody2D>();
        sr = Character.GetComponent<SpriteRenderer>();
	}
	void FixedUpdate()
    {
        float translation = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;

        transform.Translate(translation, 0, 0);

        if (translation < 0)
        {
            //sr.flipX = false;
            transform.Rotate(0, 0, 0);
        }
        else if (translation > 0)
        {
            //sr.flipX = true;
            transform.Rotate(0, 180, 0);
        }
        

        //if (Input.GetKey(KeyCode.D))
        //{
        //    //rb.velocity = (new Vector2(speed, rb.velocity.y));
        //    rb.AddForce(new Vector2(speed, rb.velocity.y));
        //    sr.flipX = true;
        //}
        //else if (Input.GetKey(KeyCode.A))
        //{
        //    //rb.velocity = (new Vector2(-speed, rb.velocity.y));
        //    rb.AddForce(new Vector2(-speed, rb.velocity.y));
        //    sr.flipX = false;
        //}

        //rb.velocity = Vector3.ClampMagnitude(rb.velocity, Maxspeed); if Addforce is used this makes a max speed

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
