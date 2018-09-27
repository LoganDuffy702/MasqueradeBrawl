using UnityEngine;
using System.Collections;

public class GravityPowerup : MonoBehaviour {

    public bool GravityOFF;
    public GameObject players;
    public float duration;
    public float ReverseGravityScale;
    public float OriginalGravity;
    Rigidbody2D rigid;
    SpriteRenderer sr;
    //BoxCollider2D fix;
    PlayerMovement SpriteFlip;
    // Use this for initialization
    void Start () {
       
        rigid = players.GetComponent<Rigidbody2D>();
        sr = players.GetComponent<SpriteRenderer>();
        //fix = players.GetComponent<BoxCollider2D>();
        
        SpriteFlip = players.GetComponent<PlayerMovement>();

    }

    void Update()
    {
        if (GravityOFF == true)
        {
            GravityFX();
            StartCoroutine(FlipTimer());
        }
        
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
            GravityOFF = true;
        }
    }
}
