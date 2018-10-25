using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {
    public enum Players { P,M,G,K}
    public Players P_HP;
    public float PlayerHP = 100;
    public float PlayerStock = 3;
    public RectTransform healthBar;
    GameObject Weapon;
    GameObject Gun;
    public float respawnTime;
    GameObject Player;
    Animator anim;
    private float CurrentHealth;
	// Use this for initialization
	void Start () {
        CurrentHealth = PlayerHP;
        switch (P_HP)
        {
            case Players.P:
                Player = GameObject.Find("_Penguin_Anim");
                Weapon = GameObject.Find("_Penguin_Weapon");
                Gun = GameObject.Find("_Penguin_Gun");
                break;
            case Players.M:
                Player = GameObject.Find("_MoonMan_Anim");
                Weapon = GameObject.Find("_MoonMan_Weapon");
                Gun = GameObject.Find("_MoonMan_Gun");
                break;
            case Players.G:
                break;
            case Players.K:
                break;
            default:
                break;
        }
        
        anim = Player.GetComponent<Animator>();
    }

    public void TakeDamage(float amount)
    {
        CurrentHealth -= amount;
        if (CurrentHealth <= 0 )
        {
            CurrentHealth = 0;


            anim.SetBool("Dead", true);
            Debug.Log(gameObject.name + " Died");
            gameObject.GetComponent<PlayerMovementRedux>().enabled = false;
            gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 0f, 0f);
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 0f;
            Weapon.GetComponent<SpriteRenderer>().enabled = false;
            Gun.GetComponent<RigidWeapon>().enabled = false;
            Gun.GetComponent<LineRenderer>().enabled = false;

            PlayerStock -= 1;
            StartCoroutine(Respawn());
        }
        if (CurrentHealth > 100)
        {
            CurrentHealth = 100;
        }
        healthBar.sizeDelta = new Vector2(CurrentHealth, healthBar.sizeDelta.y);
        if (PlayerStock <= 0)
        {
            //Game Over...
            Debug.Log("Game Over");
        }
    }
    public IEnumerator Respawn()
    {
        yield return new WaitForSeconds(respawnTime);
        gameObject.GetComponent<PlayerMovementRedux>().Recreate();
        gameObject.GetComponent<CapsuleCollider2D>().enabled = true;
        Weapon.GetComponent<SpriteRenderer>().enabled = true;
        gameObject.GetComponent<PlayerMovementRedux>().enabled = true;
        gameObject.GetComponent<Rigidbody2D>().gravityScale = 5f;
        Gun.GetComponent<RigidWeapon>().enabled = true;
        Gun.GetComponent<LineRenderer>().enabled = true;
        anim.SetBool("Dead", false);

        CurrentHealth = 100;
        healthBar.sizeDelta = new Vector2(CurrentHealth, healthBar.sizeDelta.y);
    }
}
