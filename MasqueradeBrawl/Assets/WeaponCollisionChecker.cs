using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCollisionChecker : MonoBehaviour {

    public GameObject Player;
	// Use this for initialization
	void Start () {
		
	}

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PistolBullet"))
        {
            Player.GetComponent<PlayerHealth>().TakeDamage(1);
        }
    }
}
