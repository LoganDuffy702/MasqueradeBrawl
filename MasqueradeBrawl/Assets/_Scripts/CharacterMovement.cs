using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

    public int speed;
    public bool I_flipped;
    //public float Xstart = 11.6f;
    //public float Ystart = 12.6f;

    public string[] Guns;
    //public string[] PowerUps;

	private Rigidbody2D rb;
	private SpriteRenderer sr;
    //Transform Weapon;
    public GameObject PlayerWeapon;
    GameObject PowerupName;
    SpriteRenderer SpriteProps;
    Transform SpritePos;

    public GameObject WeaponSprite;
    Transform WSTrans;
    SpriteRenderer WSsr;

    //PowerUpSelection PowerNum;
    public string WeaponTag;




    void Start(){
		rb = GetComponent<Rigidbody2D> ();
		sr = GetComponent<SpriteRenderer> ();
        WSTrans = WeaponSprite.GetComponent<Transform>();
        WSsr = WeaponSprite.GetComponent<SpriteRenderer>();
        //transform.position = (new Vector2(Xstart,Ystart));//starting Position
        //SpriteProps=PlayerWeapon.GetComponent<SpriteRenderer>();

    }



	void FixedUpdate(){
		if (Input.GetKey(KeyCode.D)) {
			rb.velocity = (new Vector2 (speed, rb.velocity.y));
			sr.flipX = false;
            //SpriteProps.flipX=false;
		}
		else if (Input.GetKey(KeyCode.A)) {
			rb.velocity = (new Vector2 (-speed, rb.velocity.y));
			sr.flipX = true;
            //SpriteProps.flipX = false;

        }

        if (I_flipped == true)
        {
            WSTrans.transform.localPosition = new Vector2(0.007f, -0.32f);
            WSsr.flipY = true;
        
        }
        else if (I_flipped == false)
        {
            WSTrans.transform.localPosition = new Vector2(0.007f, 0.32f);
            WSsr.flipY = false;
        }

	}

	void OnTriggerEnter2D(Collider2D other){
        //if (other.gameObject.CompareTag("Portal1A")) {
        //	transform.position = (new Vector2 (10.75f, 19.3f));
        //}
        //else if (other.gameObject.CompareTag("Portal2A")) {
        //	transform.position = (new Vector2 (11.21f, 10.63f));
        //}
        //else if (other.gameObject.CompareTag("Portal3A")) {
        //	transform.position = (new Vector2 (0.88f, 19.34f));
        //}
        //else if (other.gameObject.CompareTag("Portal4A")) {
        //	transform.position = (new Vector2 (21.55f, 19.34f));
        //}
        //else if (other.gameObject.CompareTag("Portal5A")) {
        //	transform.position = (new Vector2 (8.6f, 14.59f));
        //}
        //else if (other.gameObject.CompareTag("Portal6A")) {
        //	transform.position = (new Vector2 (21.66f, 12.69f));
        //}
        Debug.Log("Touching");
	}


}
