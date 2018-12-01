using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PlayerMovementRedux : MonoBehaviour {

    public enum Player { MoonMan, Penguin, ButtLady, FoxMan }
    public enum PlayerPos { Player1, Player2, Player3, Player4 }
    public PlayerPos PlayerController;

    public Player choosePlayr;
    Vector3 direction;
    public int Speed;
    Vector3 currVel;
    
    //float MoveNum;

    GameObject Character;

    Animator anim;

    public GameObject Weapon;
    Transform WSTrans;
    public float PlayerX, PlayerY;

    SpriteRenderer WSsr;
    SpriteRenderer PlayerSprite;

    Rigidbody2D rb2;
    //CapsuleCollider2D CC2D;

    void Start()
    {
        switch (choosePlayr)
        {
            case Player.MoonMan:
                Character = GameObject.Find("_MoonMan_Anim");
                break;
            case Player.Penguin:
                Character = GameObject.Find("_Penguin_Anim");
                break;
            case Player.ButtLady:
                Character = GameObject.Find("_ButtLady_Anim");
                break;
            case Player.FoxMan:
                Character = GameObject.Find("_Foxy_Anim");
                break;
            default:
                break;
        }
        
        rb2 = gameObject.GetComponent<Rigidbody2D>();
        //CC2D = gameObject.GetComponent<CapsuleCollider2D>();
        WSTrans = Weapon.GetComponent<Transform>();
        WSsr = Weapon.GetComponent<SpriteRenderer>();
        anim = Character.GetComponent<Animator>();
        PlayerSprite = Character.GetComponent<SpriteRenderer>();
        Recreate();
        
    }

    public void Recreate()
    {
        gameObject.transform.position = new Vector3(PlayerX,PlayerY,0);
    }

    void Update()
    {
        switch (choosePlayr)
        {
            case Player.MoonMan:
                switch (PlayerController)
                {
                    case PlayerPos.Player1:
                        direction.x = Input.GetAxis("Horizontal1");
                        anim.SetFloat("Speed", Mathf.Abs(direction.x));
                        break;
                    case PlayerPos.Player2:
                        direction.x = Input.GetAxis("Horizontal2");
                        anim.SetFloat("Speed", Mathf.Abs(direction.x));
                        break;
                    case PlayerPos.Player3:
                        direction.x = Input.GetAxis("Horizontal3");
                        anim.SetFloat("Speed", Mathf.Abs(direction.x));
                        break;
                    case PlayerPos.Player4:
                        direction.x = Input.GetAxis("Horizontal4");
                        anim.SetFloat("Speed", Mathf.Abs(direction.x));
                        break;
                    default:
                        break;
                }
                break;

            case Player.Penguin:
                switch (PlayerController)
                {
                    case PlayerPos.Player1:
                        direction.x = Input.GetAxis("Horizontal1");
                        anim.SetFloat("Speed", Mathf.Abs(direction.x));
                        break;
                    case PlayerPos.Player2:
                        direction.x = Input.GetAxis("Horizontal2");
                        anim.SetFloat("Speed", Mathf.Abs(direction.x));
                        break;
                    case PlayerPos.Player3:
                        direction.x = Input.GetAxis("Horizontal3");
                        anim.SetFloat("Speed", Mathf.Abs(direction.x));
                        break;
                    case PlayerPos.Player4:
                        direction.x = Input.GetAxis("Horizontal4");
                        anim.SetFloat("Speed", Mathf.Abs(direction.x));
                        break;
                    default:
                        break;
                }
                break;

            case Player.ButtLady:
                switch (PlayerController)
                {
                    case PlayerPos.Player1:
                        direction.x = Input.GetAxis("Horizontal1");
                        anim.SetFloat("Speed", Mathf.Abs(direction.x));
                        break;
                    case PlayerPos.Player2:
                        direction.x = Input.GetAxis("Horizontal2");
                        anim.SetFloat("Speed", Mathf.Abs(direction.x));
                        break;
                    case PlayerPos.Player3:
                        direction.x = Input.GetAxis("Horizontal3");
                        anim.SetFloat("Speed", Mathf.Abs(direction.x));
                        break;
                    case PlayerPos.Player4:
                        direction.x = Input.GetAxis("Horizontal4");
                        anim.SetFloat("Speed", Mathf.Abs(direction.x));
                        break;
                    default:
                        break;
                }

                break;
            case Player.FoxMan:

                switch (PlayerController)
                {
                    case PlayerPos.Player1:
                        direction.x = Input.GetAxis("Horizontal1");
                        anim.SetFloat("Speed", Mathf.Abs(direction.x));
                        break;
                    case PlayerPos.Player2:
                        direction.x = Input.GetAxis("Horizontal2");
                        anim.SetFloat("Speed", Mathf.Abs(direction.x));
                        break;
                    case PlayerPos.Player3:
                        direction.x = Input.GetAxis("Horizontal3");
                        anim.SetFloat("Speed", Mathf.Abs(direction.x));
                        break;
                    case PlayerPos.Player4:
                        direction.x = Input.GetAxis("Horizontal4");
                        anim.SetFloat("Speed", Mathf.Abs(direction.x));
                        break;
                    default:
                        break;
                }

                break;
            default:
                break;
        }

        Move();
    }
	
    void Move()
    {
        switch (choosePlayr)
        {
            case Player.MoonMan:
                transform.Translate(direction.x * Speed * Time.deltaTime, 0, 0);
                break;
            case Player.Penguin:
                transform.Translate(direction.x * Speed * Time.deltaTime, 0, 0);
                break;
            case Player.ButtLady:
                transform.Translate(direction.x * Speed * Time.deltaTime, 0, 0);
                break;
            case Player.FoxMan:
                transform.Translate(direction.x * Speed * Time.deltaTime, 0, 0);
                break;
            default:
                break;
        }



        
    }

    

    public void Gravity_PP()
    {
        rb2.gravityScale = -2.5f;
        //CC2D.offset = new Vector2(0f, 0.15f);
        WSTrans.transform.localPosition = new Vector2(0.007f, -0.32f);
        WSsr.flipY = true;
        PlayerSprite.flipY = true;
       
        StartCoroutine(FlipTimer());

    }

    public IEnumerator FlipTimer()
    {
        yield return new WaitForSeconds(3f);
        Gravity_PP_Fix();
    }

    public void Gravity_PP_Fix()
    {
        
        rb2.gravityScale = 5f;
        //CC2D.offset = new Vector2(0f, -0.12f);
        WSTrans.transform.localPosition = new Vector2(0.007f, 0.32f);
        WSsr.flipY = false;
        PlayerSprite.flipY = false;

    }

}
