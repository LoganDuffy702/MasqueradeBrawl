using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GravityPowerup : MonoBehaviour
{
    public float Effect_duration;
    public GameObject OnContact;
    public float OriginalGravity;
    public float LifeSpan;
   
  
    void Start ()
    {
        StartCoroutine(HidMe());
    }

    public IEnumerator HidMe()
    {
        yield return new WaitForSeconds(LifeSpan);
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        Destroy(gameObject,Effect_duration+10);
    }

    public void FindPlayer(GameObject PlayerName)
    {
        GameObject PlayerObject = GameObject.Find(PlayerName.name);
        PlayerObject.GetComponent<PlayerMovementRedux>().Gravity_PP();
    }
   
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Penguin") || col.gameObject.tag.Equals("MoonMan") || col.gameObject.tag.Equals("ButtLady"))
        {
           
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            FindPlayer(col.gameObject);
            Instantiate(OnContact, transform.localPosition, transform.localRotation);
        }
    }
}
