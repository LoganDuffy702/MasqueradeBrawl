using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public GameObject Character;
    public string MovementControls;
    //Rigidbody2D rb;
    //SpriteRenderer sr;
    public float speed;
    public float Maxspeed;
    public float KeyBoardSpeed;
    public bool Flipped;

    Animator anim;
    public GameObject WeaponSprite;
    Transform WSTrans;
    SpriteRenderer WSsr;

    void Start () {
        //rb = Character.GetComponent<Rigidbody2D>();
        //sr = Character.GetComponent<SpriteRenderer>();
        Character = GameObject.Find("_Player1_Anim");
        WSTrans = WeaponSprite.GetComponent<Transform>();
        WSsr = WeaponSprite.GetComponent<SpriteRenderer>();
        anim = Character.GetComponent<Animator>();
    }
	void FixedUpdate()
    {

        transform.Translate(new Vector3(Input.GetAxis(MovementControls) * speed * Time.deltaTime, 0,0));
        var run = Input.GetAxis(MovementControls);

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-KeyBoardSpeed * Time.deltaTime, 0, 0));
            run = 1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(KeyBoardSpeed * Time.deltaTime, 0, 0));
            run = 1;
        }
        
        //rb.AddForce(new Vector3(translation * Time.deltaTime, 0, 0));
        if (run > 0 || run < 0)
        {
            anim.enabled = true;
        }
        else if (run == 0)
        {
            anim.enabled = false;
        }
        //rb.velocity = Vector3.ClampMagnitude(rb.velocity, Maxspeed);

        if (Flipped == true)
        {
            WSTrans.transform.localPosition = new Vector2(0.007f, -0.32f);
            WSsr.flipY = true;

        }
        else if (Flipped == false)
        {
            WSTrans.transform.localPosition = new Vector2(0.007f, 0.32f);
            WSsr.flipY = false;
        }

    }
	
	
}
