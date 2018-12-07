using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {
   
    public float PlayerHP;
    public float PlayerStock = 2;
    //public int PlayerMarker = 0;
    public RectTransform healthBar;
    public bool PlayerDead = false;
    public GameObject MainCanvas;
    public AudioSource DamageSound,HealSound;
    public string DeathSoundName;
    AudioSource Deathsound;
    public GameObject PlayerAnimation;
    public GameObject PlayerWeapon;
    public GameObject PlayerGun;
    public GameObject StockCounter;
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
       

        Player = PlayerAnimation; //GameObject.Find("_ButtLady_Anim");
        Weapon = PlayerWeapon;// GameObject.Find("_ButtLady_Weapon");
        Gun = PlayerGun;// GameObject.Find("_ButtLady_Gun");
        RigidWeapon thigny = Gun.GetComponent<RigidWeapon>();
        thigny.enabled = false;
        


        anim = Player.GetComponent<Animator>();
    }

    public void TakeDamage(float amount)
    {
        
        CurrentHealth += amount;
        Dtaken = true;
        if (amount < 0)
        {
            DamageSound.Play();
            StartCoroutine(dmg());
        }
        if (amount > 0)
        {
            HealSound.Play();
        }
        
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
                StockCounter.GetComponent<PlayerStock>().DeathStock(1);
                PlayerDead = true;
                Debug.Log("PLayer out of stocks");
                MainCanvas.GetComponent<WinnerScript>().WinChecker();
                StartCoroutine(HideMe());
                
                
            }
            else if (PlayerStock > 0)
            {
                StockCounter.GetComponent<PlayerStock>().DeathStock(1);
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
