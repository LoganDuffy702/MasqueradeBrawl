using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Drop : MonoBehaviour {

    public GameObject OnContact;

    public int BurstSize;
    public float reload_speed;
    public string GunSound;
    GameObject GunsoundObject;
    
    public bool ShotGunMode;
   
    public GameObject Weapon;
    public float LifeSpan;
    // Use this for initialization
    void Start () {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<CircleCollider2D>().enabled = false;
        StartCoroutine(ShowMe());
        StartCoroutine(HidMe());
        GunsoundObject = GameObject.Find(GunSound);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public IEnumerator ShowMe()
    {
        yield return new WaitForSeconds(1);
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        gameObject.GetComponent<CircleCollider2D>().enabled = true;
    }

    public void ChangeWeapon(GameObject P_Weapon_Name)
    {
        string remove = "(Clone)";
        string Original = P_Weapon_Name.name;
        string result = Original.Replace(remove,"");
        GameObject PlayerGun = GameObject.Find(result+"_Gun");
        GameObject PlayerObject = GameObject.Find(P_Weapon_Name.name);
        Debug.Log(PlayerObject.name);
        RigidWeapon P_Gun = PlayerGun.GetComponent<RigidWeapon>();//Butt lady throws error here

        //Ammo Section-------------------------------------------------
        PlayerObject.GetComponent<PlayerAmmo>().AddClip();
        P_Gun.Ammo = 22;
        //Gun Properties Section---------------------------------------
        P_Gun.TypeOfBullet = Weapon;
        P_Gun.burstSize = BurstSize;
        P_Gun.ReloadSpeed = reload_speed;
        P_Gun.ShotGunMode = ShotGunMode;
        P_Gun.Gunsound = GunsoundObject.GetComponent<AudioSource>(); ;

        
    }

    public IEnumerator HidMe()
    {
        yield return new WaitForSeconds(LifeSpan);
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<CircleCollider2D>().enabled = false;
        Destroy(gameObject, LifeSpan + 10);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Penguin") || other.gameObject.CompareTag("MoonMan") || 
            other.gameObject.CompareTag("ButtLady")|| other.gameObject.CompareTag("Foxy"))
        {

            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<CircleCollider2D>().enabled = false;
            ChangeWeapon(other.gameObject);
            Instantiate(OnContact, transform.position, transform.rotation);
        }

    }
}
