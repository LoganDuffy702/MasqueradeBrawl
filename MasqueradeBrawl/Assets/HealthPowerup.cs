using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerup : MonoBehaviour {

    public float AddHealth = 10;
    public GameObject OnContact;
    private GameObject Player1;
    public float LifeSpan = 5;
    public float duration;
    // Use this for initialization
    void Start () {
        Player1 = GameObject.Find("_Player1");
        if (Player1 == null)
        {
            Debug.Log("NO PLAYER found");
        }
        StartCoroutine(HidMe());
    }

    public IEnumerator HidMe()
    {
        yield return new WaitForSeconds(LifeSpan);
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<CircleCollider2D>().enabled = false;
        Destroy(gameObject, duration + 10);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Players"))
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<CircleCollider2D>().enabled = false;
            Instantiate(OnContact, transform.localPosition, transform.localRotation);
            Player1.GetComponent<PlayerHealth>().TakeDamage(-AddHealth);
        }
    }
}
