using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerup : MonoBehaviour {

    public float AddHealth = 10;
    public GameObject OnContact;
    private GameObject Player1;
    public float LifeSpan = 5;
    
    // Use this for initialization
    void Start ()
    {
        StartCoroutine(HidMe());
    }

    public IEnumerator HidMe()
    {
        yield return new WaitForSeconds(LifeSpan);
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<CircleCollider2D>().enabled = false;
        Destroy(gameObject, LifeSpan + 10);
    }

    public void FindHealth(GameObject PlayerName)
    {
        GameObject PlayerObject = GameObject.Find(PlayerName.name);
        PlayerObject.GetComponent<PlayerHealth>().TakeDamage(AddHealth);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("MoonMan") || other.gameObject.CompareTag("Penguin") ||
            other.gameObject.CompareTag("ButtLady")|| other.gameObject.CompareTag("Foxy"))
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<CircleCollider2D>().enabled = false;
            FindHealth(other.gameObject);
            Instantiate(OnContact, transform.localPosition, transform.localRotation);
            
        }
    }
}
