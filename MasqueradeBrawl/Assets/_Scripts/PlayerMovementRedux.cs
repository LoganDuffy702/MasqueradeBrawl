using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PlayerMovementRedux : MonoBehaviour {

    public enum Player { Player1,Player2,Player3,Player4}

    public Player choosePlayr;
    Vector3 direction;
    public int Speed;
    public bool Flipped;
    Vector3 currVel;
    
    float MoveNum;

    GameObject Character;
    Animator anim;
    public GameObject Weapon;
    Transform WSTrans;

    SpriteRenderer WSsr;
    SpriteRenderer PlayerSprite;

    Rigidbody2D rb2;
    CapsuleCollider2D CC2D;

    void Start()
    {
        switch (choosePlayr)
        {
            case Player.Player1:
                Character = GameObject.Find("_Player1_Anim");
                break;
            case Player.Player2:
                Character = GameObject.Find("_Player2_Anim");
                break;
            case Player.Player3:
                break;
            case Player.Player4:
                break;
            default:
                break;
        }
        
        rb2 = gameObject.GetComponent<Rigidbody2D>();
        CC2D = gameObject.GetComponent<CapsuleCollider2D>();
        WSTrans = Weapon.GetComponent<Transform>();
        WSsr = Weapon.GetComponent<SpriteRenderer>();
        anim = Character.GetComponent<Animator>();
        PlayerSprite = Character.GetComponent<SpriteRenderer>();


    }

    void Update()
    {
        switch (choosePlayr)
        {
            case Player.Player1:
                direction.x = Input.GetAxis("Horizontal");

                if (Input.GetKey(KeyCode.A))
                {
                    transform.Translate(-Speed * Time.deltaTime, 0, 0);
                }
                else if (Input.GetKey(KeyCode.D))
                {
                    transform.Translate(Speed * Time.deltaTime, 0, 0);
                }

                break;
            case Player.Player2:
                direction.x = Input.GetAxis("Horizontal2");

                if (Input.GetKey(KeyCode.A))
                {
                    transform.Translate(-Speed * Time.deltaTime, 0, 0);
                }
                else if (Input.GetKey(KeyCode.D))
                {
                    transform.Translate(Speed * Time.deltaTime, 0, 0);
                }

                break;
            case Player.Player3:
                direction.x = Input.GetAxis("Horizontal3");
                
                break;
            case Player.Player4:
                direction.x = Input.GetAxis("Horizontal4");
                
                break;
            default:
                break;
        }
        Move();
    }
	
    void Move()
    {

        StartCoroutine(CalcVelocity());
        transform.Translate(direction.x*Speed * Time.deltaTime, 0, 0);
        //run = direction.x;

        if (MoveNum > 0 || MoveNum < 0) 
            anim.enabled = true;
        else if (MoveNum == 0)
            anim.enabled = false;

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

    public IEnumerator CalcVelocity()
    {
        while (Application.isPlaying)
        {
            // Position at frame start
            Vector3 prevPos = transform.position;
            // Wait till it the end of the frame
            yield return new WaitForEndOfFrame();
            // Calculate velocity: Velocity = DeltaPosition / DeltaTime
            currVel = (prevPos - transform.position) / Time.deltaTime;
            MoveNum = currVel.x;
        }

    }

    public void Gravity_PP()
    {
        rb2.gravityScale = -2.5f;
        CC2D.offset = new Vector2(0f, 0.15f);
        WSTrans.transform.localPosition = new Vector2(0.007f, -0.32f);
        WSsr.flipY = true;
        PlayerSprite.flipY = true;
        Debug.Log("FLIP TIMER STARTED");
        StartCoroutine(FlipTimer());

    }

    public IEnumerator FlipTimer()
    {
        yield return new WaitForSeconds(3f);
        Gravity_PP_Fix();
    }

    public void Gravity_PP_Fix()
    {
        Debug.Log("FLIP TIMER ENDED");
        rb2.gravityScale = 5f;
        CC2D.offset = new Vector2(0f, -0.12f);
        WSTrans.transform.localPosition = new Vector2(0.007f, 0.32f);
        WSsr.flipY = false;
        PlayerSprite.flipY = false;

    }

}
