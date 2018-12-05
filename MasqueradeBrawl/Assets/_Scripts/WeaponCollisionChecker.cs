using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCollisionChecker : MonoBehaviour {

    public GameObject Player;
    public enum PlayerSelect { Penguin, Man, Foxy, Lady }
    public PlayerSelect PlayerName;
	void Start () {
       

    }
    //case1 use these stats
    public void OnTriggerEnter2D(Collider2D other)
    {
        switch (PlayerName)
        {
            case PlayerSelect.Penguin:
                if (other.gameObject.CompareTag("PistolBullet"))
                {
                    Player.GetComponent<PlayerHealth>().TakeDamage(-2);
                }
                if (other.gameObject.CompareTag("LobShot"))
                {
                    Player.GetComponent<PlayerHealth>().TakeDamage(-15);
                }
                if (other.gameObject.CompareTag("FlameThrower"))
                {
                    Player.GetComponent<PlayerHealth>().TakeDamage(-11);
                }
                if (other.gameObject.CompareTag("MG_Bullet"))
                {
                    Player.GetComponent<PlayerHealth>().TakeDamage(-5);
                }
                if (other.gameObject.CompareTag("ShotgunBullet"))
                {
                    Player.GetComponent<PlayerHealth>().TakeDamage(-5);
                }
                break;
            case PlayerSelect.Man:
                if (other.gameObject.CompareTag("PistolBullet"))
                {
                    Player.GetComponent<PlayerHealth>().TakeDamage(-5);
                }
                if (other.gameObject.CompareTag("LobShot"))
                {
                    Player.GetComponent<PlayerHealth>().TakeDamage(-15);
                }
                if (other.gameObject.CompareTag("FlameThrower"))
                {
                    Player.GetComponent<PlayerHealth>().TakeDamage(-5);
                }
                if (other.gameObject.CompareTag("MG_Bullet"))
                {
                    Player.GetComponent<PlayerHealth>().TakeDamage(-5);
                }
                if (other.gameObject.CompareTag("ShotgunBullet"))
                {
                    Player.GetComponent<PlayerHealth>().TakeDamage(-5);
                }
                break;
            case PlayerSelect.Foxy:
                if (other.gameObject.CompareTag("PistolBullet"))
                {
                    Player.GetComponent<PlayerHealth>().TakeDamage(-10);
                }
                if (other.gameObject.CompareTag("LobShot"))
                {
                    Player.GetComponent<PlayerHealth>().TakeDamage(-15);
                }
                if (other.gameObject.CompareTag("FlameThrower"))
                {
                    Player.GetComponent<PlayerHealth>().TakeDamage(-5);
                }
                if (other.gameObject.CompareTag("MG_Bullet"))
                {
                    Player.GetComponent<PlayerHealth>().TakeDamage(-8);
                }
                if (other.gameObject.CompareTag("ShotgunBullet"))
                {
                    Player.GetComponent<PlayerHealth>().TakeDamage(-8);
                }
                break;
            case PlayerSelect.Lady:
                if (other.gameObject.CompareTag("PistolBullet"))
                {
                    Player.GetComponent<PlayerHealth>().TakeDamage(-15);
                }
                if (other.gameObject.CompareTag("LobShot"))
                {
                    Player.GetComponent<PlayerHealth>().TakeDamage(-20);
                }
                if (other.gameObject.CompareTag("FlameThrower"))
                {
                    Player.GetComponent<PlayerHealth>().TakeDamage(-3);
                }
                if (other.gameObject.CompareTag("MG_Bullet"))
                {
                    Player.GetComponent<PlayerHealth>().TakeDamage(-2);
                }
                if (other.gameObject.CompareTag("ShotgunBullet"))
                {
                    Player.GetComponent<PlayerHealth>().TakeDamage(-4);
                }
                break;
            default:
                break;
        }
    }
}
