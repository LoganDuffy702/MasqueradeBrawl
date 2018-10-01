﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GravityPowerup : MonoBehaviour {

    public bool GravityOFF;
    //public List<GameObject> players = new List<GameObject>();
    private GameObject Player1;
    private GameObject PlayerSprite;
    public float duration;
    public float ReverseGravityScale;
    public GameObject OnContact;
    public float OriginalGravity;
    public float LifeSpan;
    Rigidbody2D rigid;
    SpriteRenderer sr;
    //BoxCollider2D fix;
    PlayerMovement SpriteFlip;
    // Use this for initialization
    void Start () {

        Player1 = GameObject.Find("_Player1");
        PlayerSprite = GameObject.Find("_Player1_Anim");
        if (Player1 == null)
        {
            Debug.Log("NO PLAYER found");
        }
        rigid = Player1.GetComponent<Rigidbody2D>();
        sr = PlayerSprite.GetComponent<SpriteRenderer>();
        SpriteFlip = Player1.GetComponent<PlayerMovement>();

        StartCoroutine(HidMe());

    }

    void Update()
    {
        if (GravityOFF == true)
        {
            GravityFX();
            StartCoroutine(FlipTimer());
        }
       
    }

    public IEnumerator HidMe()
    {
        yield return new WaitForSeconds(LifeSpan);
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        Destroy(gameObject,duration+10);
    }

    void GravityFX()
    {
        SpriteFlip.Flipped = true;
        //fix.offset = new Vector2(-0.08f, -0.09f);
        sr.flipY = true;
        rigid.gravityScale = ReverseGravityScale;
    }
    void GravityFIX()
    {
        SpriteFlip.Flipped = false;
        //fix.offset = new Vector2(-0.08f, .1f);
        sr.flipY = false;
        rigid.gravityScale = OriginalGravity;
        Destroy(gameObject);
    }
    public IEnumerator FlipTimer()
    {
        yield return new WaitForSeconds(duration);
        GravityOFF = false;
        GravityFIX();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Players"))
        {
           
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            Instantiate(OnContact, transform.localPosition, transform.localRotation);
            GravityOFF = true;
        }
    }
}
