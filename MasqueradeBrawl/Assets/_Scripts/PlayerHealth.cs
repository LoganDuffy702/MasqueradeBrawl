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
    public bool PlayerDead = false;
    public GameObject MainCanvas;
    public AudioSource DamageSound;
    public string DeathSoundName;
    AudioSource Deathsound;
    public GameObject PlayerAnimation;
    public GameObject PlayerWeapon;
    public GameObject PlayerGun;
    bool waiting, Dtaken;
    
    GameObject Weapon;
   
    GameObject Gun;
    
    public float respawnTime;
    GameObject Player;
    Animator anim;
    private float CurrentHealth;
	// Use this for initialization
	void Start () {
        MainCanvas = GameObject.Find("Main_Canvas");
        CurrentHealth = PlayerHP;
        Deathsound = GameObject.Find(DeathSoundName).GetComponent<AudioSource>();
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
                Player = PlayerAnimation; //GameObject.Find("_ButtLady_Anim");
                Weapon = PlayerWeapon;// GameObject.Find("_ButtLady_Weapon");
                Gun = PlayerGun;// GameObject.Find("_ButtLady_Gun");
                RigidWeapon thigny = Gun.GetComponent<RigidWeapon>();
                thigny.enabled = false;
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
        DamageSound.Play();
        CurrentHealth += amount;
        StartCoroutine(dmg());
        Dtaken = true;
        if (CurrentHealth <= 0 )
        {
            CurrentHealth = 0;
            Deathsound.Play();
            anim.SetBool("Dead", true);
            Debug.Log(gameObject.name + " Died");
            gameObject.GetComponent<PlayerMovementRedux>().enabled = false;
            gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 0f, 0f);
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 0f;
            Weapon.GetComponent<SpriteRenderer>().enabled = false;
            //Gun.GetComponent<RigidWeapon>().enabled = false;//Butt lady is throws error here
            Gun.GetComponent<LineRenderer>().enabled = false;

            PlayerStock -= 1;
            if (PlayerStock <= 0)
            {
                PlayerDead = true;
                Debug.Log("PLayer out of stocks");
                MainCanvas.GetComponent<WinnerScript>().WinChecker();
                StartCoroutine(HideMe());
                
                
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
    
    public IEnumerator dmg()
    {
        if (Dtaken == true && waiting == false)
        {
            waiting = true;
            anim.SetBool("Damage", true);
            int temp = gameObject.GetComponent<PlayerMovementRedux>().Speed;
            gameObject.GetComponent<PlayerMovementRedux>().Speed = 3;
            yield return new WaitForSeconds(.4f);///This will need some polish
            gameObject.GetComponent<PlayerMovementRedux>().Speed = temp;
            anim.SetBool("Damage", false);
            waiting = false;
           
        }
        else if (Dtaken == true && waiting == true)
        {
            Debug.Log("Waiting");
        }

      
    }
    public IEnumerator HideMe()
    {
        yield return new WaitForSeconds(4);
        Destroy(gameObject);
    }
}
