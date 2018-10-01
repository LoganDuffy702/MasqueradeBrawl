using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFalloff : MonoBehaviour {

    public GameObject player;
    Rigidbody2D rb;
    // Use this for initialization
    void Start () {
        rb = player.GetComponent<Rigidbody2D>();
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Falloff"))
        {
            topSpawn();
        }
        else if (other.gameObject.CompareTag("Roof"))
        {
            BottomSpawn();
        }
        else if (other.gameObject.CompareTag("RightBoarder"))
        {
            LeftSpawn();
        }
        else if (other.gameObject.CompareTag("LeftBoarder"))
        {
            RightSpawn();
        }
    }

    void topSpawn()
    {
        rb.velocity = new Vector2(0, 0);
        transform.position = new Vector2(transform.position.x, -(transform.position.y-3));
        
    }
    void BottomSpawn()
    {
        rb.velocity = new Vector2(0, 0);
        transform.position = new Vector2(transform.position.x, 0f);
    }
    void LeftSpawn()
    {
        rb.velocity = new Vector2(0, 0);
        transform.position = new Vector2(-transform.position.x, transform.position.y);
    }
    void RightSpawn()
    {
        rb.velocity = new Vector2(0, 0);
        transform.position = new Vector2(-transform.position.x, transform.position.y);
    }
}
