using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ammo_PP : MonoBehaviour {

    //private Camera Camera1;
    public GameObject OnContact;
    public float LifeSpan;
    GameObject AmmoOBJ;
    public GameObject AmmoSprite;
    private RigidWeapon PlayerAmmo;
    private Image AmmoIMG;
    public int AmmoAmmount = 16;
    AudioSource ReloadSound;
    GameObject AmmoPos;
    public GameObject AmmoPrefab;


    // Use this for initialization
    void Start ()
    {
        StartCoroutine(HidMe());
        ReloadSound = GameObject.Find("ReloadSound").GetComponent<AudioSource>();
    }

    public void AddAmmo(GameObject PlayerName)
    {   
        //GameObject PlayerObject = GameObject.Find(PlayerName.name);
        PlayerName.GetComponent<PlayerAmmo>().AddClip();
        PlayerName.GetComponent<AudioSource>().Play();
    }

    public IEnumerator HidMe()
    {
        yield return new WaitForSeconds(LifeSpan);
        AmmoSprite.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        Destroy(gameObject, LifeSpan + 10);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Penguin") || other.gameObject.CompareTag("MoonMan") 
            || other.gameObject.CompareTag("ButtLady")|| other.gameObject.CompareTag("Foxy"))
        {
            ReloadSound.Play();
            //Debug.Log("Reload");
            AmmoSprite.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
           
            AddAmmo(other.gameObject);
            Instantiate(OnContact, transform.localPosition, transform.localRotation);
            Destroy(gameObject);
        }

    }
}
