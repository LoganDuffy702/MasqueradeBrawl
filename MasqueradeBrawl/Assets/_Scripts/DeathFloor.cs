using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathFloor : MonoBehaviour {

    //GameObject Platform;
    //GameObject PowerUp;
    //PlayerHealth playerHP;
    void Start()
    {
        //Platform = GameObject.FindWithTag("DeathFloor");
        //PowerUp = GameObject.FindWithTag("PowerUp");
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Walls")) 
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Penguin") || other.gameObject.CompareTag("MoonMan") ||
            other.gameObject.CompareTag("ButtLady") || other.gameObject.CompareTag("Foxy"))
        {
            other.GetComponent<PlayerHealth>().TakeDamage(-30);
        }
    }
}
