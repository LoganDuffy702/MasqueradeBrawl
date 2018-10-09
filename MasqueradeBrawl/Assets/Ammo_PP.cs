using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ammo_PP : MonoBehaviour {

    //private Camera Camera1;
    public GameObject OnContact;
    public float LifeSpan;
    GameObject AmmoOBJ;
    private RigidWeapon PlayerAmmo;
    private Image AmmoIMG;
    public int AmmoAmmount = 16;
    private int AddedAmmo;
    GameObject AmmoPos;
    public GameObject AmmoPrefab;

    // Use this for initialization
    void Start () {
        //AmmoOBJ = GameObject.Find("AmmoUI1");
        AmmoPos = GameObject.Find("Ammo Section");
        PlayerAmmo = GameObject.Find("GunTip1").GetComponent<RigidWeapon>();
        //Debug.Log(PlayerAmmo.name);
        StartCoroutine(HidMe());

    }

    public void AddAmmo()
    {
        GameObject[] AmmoOBJ = GameObject.FindGameObjectsWithTag("AmmoClips");
        for (int i = 0; i < PlayerAmmo.Ammo; i++)
        {
            Destroy(AmmoOBJ[i]);
        }

        if (AmmoAmmount >= 16)
        {
            AddedAmmo = AmmoAmmount;
            PlayerAmmo.Ammo = AddedAmmo;
            //line that sends the ammo to the rigid weapon
            int temp = 16;

            //Debug.Log(AmmoPos.name);
            for (int i = 0; i < temp; i++)
            {
                var AmmoClone = Instantiate(AmmoPrefab);
                AmmoClone.transform.SetParent(AmmoPos.transform);
                AmmoClone.transform.localScale = new Vector2(0.015f, .12f);
                AmmoClone.transform.position = new Vector2(AmmoPos.transform.position.x + (0.2f * i), AmmoPos.transform.position.y);

            }

        }
        
    }

    public IEnumerator HidMe()
    {
        yield return new WaitForSeconds(LifeSpan);
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        Destroy(gameObject, LifeSpan + 10);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Players"))
        {

            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            AddAmmo();
            Instantiate(OnContact, transform.localPosition, transform.localRotation);
            

        }

    }
}
