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

    void Start()
    {
        Character = GameObject.Find("_Player1_Anim");
        WSTrans = Weapon.GetComponent<Transform>();
        WSsr = Weapon.GetComponent<SpriteRenderer>();
        anim = Character.GetComponent<Animator>();
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

}
