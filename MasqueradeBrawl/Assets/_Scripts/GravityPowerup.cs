using UnityEngine;
using System.Collections;

public class GravityPowerup : MonoBehaviour {

    public bool GravityOFF;
    public GameObject players;
    public float duration;
    Rigidbody2D rigid;
    SpriteRenderer sr;
    BoxCollider2D fix;
    CharacterMovement SpriteFlip;
    // Use this for initialization
    void Start () {
        rigid = players.GetComponent<Rigidbody2D>();
        sr = players.GetComponent<SpriteRenderer>();
        fix = players.GetComponent<BoxCollider2D>();
        SpriteFlip = players.GetComponent<CharacterMovement>();
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
        SpriteFlip.I_flipped = true;
        fix.offset = new Vector2(-0.08f, -0.09f);
        sr.flipY = true;
        rigid.gravityScale = -1;
    }
    void GravityFIX()
    {
        SpriteFlip.I_flipped = false;
        fix.offset = new Vector2(-0.08f, .1f);
        sr.flipY = false;
        rigid.gravityScale = 2;
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
        if (col.gameObject.tag.Equals("Player"))
        {
           
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            GravityOFF = true;
        }
    }
}
