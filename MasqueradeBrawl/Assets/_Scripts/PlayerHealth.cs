using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {
    public enum Players { P,M,G,K}
    public Players P_HP;
    public float PlayerHP;
    public float PlayerStock = 2;
    public int PlayerMarker = 0;
    public RectTransform healthBar;
    public GameObject MainCanvas;
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
                PlayerMarker = 1;
                break;
            case Players.M:
                Player = GameObject.Find("_MoonMan_Anim");
                Weapon = GameObject.Find("_MoonMan_Weapon");
                Gun = GameObject.Find("_MoonMan_Gun");
                PlayerMarker = 2;
                break;
            case Players.G:
                Player = GameObject.Find("_ButtLady_Anim");
                Weapon = GameObject.Find("_ButtLady_Weapon");
                Gun = GameObject.Find("_ButtLady_Gun");
                PlayerMarker = 3;
                break;
            case Players.K:
                Player = GameObject.Find("_Foxy_Anim");
                Weapon = GameObject.Find("_Foxy_Weapon");
                Gun = GameObject.Find("_Foxy_Gun");
                PlayerMarker = 4;
                break;
            default:
                break;
        }
        
        anim = Player.GetComponent<Animator>();
    }

    public void TakeDamage(float amount)
    {
        CurrentHealth -= amount;
        anim.SetBool("Damage", true);
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
            if (PlayerStock <= 0)
            {
                MainCanvas.GetComponent<WinnerScript>().WinNum = PlayerMarker;
                gameObject.SetActive(false);
                
            }
            else if (PlayerStock > 0)
            {
                StartCoroutine(Respawn());
 
            }
            

        }
        if (CurrentHealth > 100)
        {
            CurrentHealth = 100;
        }

       

        healthBar.sizeDelta = new Vector2(CurrentHealth, healthBar.sizeDelta.y);
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

        CurrentHealth = PlayerHP;
        healthBar.sizeDelta = new Vector2(CurrentHealth, healthBar.sizeDelta.y);
    }


}
