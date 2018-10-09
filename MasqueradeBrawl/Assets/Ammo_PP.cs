using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ammo_PP : MonoBehaviour {

    //private Camera Camera1;
    public float duration;
    public GameObject OnContact;
    public float LifeSpan;
    GameObject AmmoOBJ;
    private Image AmmoIMG;
    public int AmmoAmmount;
    private int AddedAmmo;

    // Use this for initialization
    void Start () {
        AmmoOBJ = GameObject.Find("AmmoUI1");
        AmmoIMG = GameObject.Find("Ammo_Stock1").GetComponent<Image>();

    }

    public void AddAmmo()
    {
        if (AmmoAmmount >= 30)
        {
            AddedAmmo = AmmoAmmount;
            //line that sends the ammo to the rigid weapon
            int Clips = 30;

            for (int i = 0; i < Clips ; i++)
            {
                var AmmoClone = Instantiate(AmmoIMG);
                AmmoClone.transform.SetParent(AmmoOBJ.transform);
                AmmoClone.transform.position = new Vector2(AmmoIMG.transform.position.x + (0.2f * i), AmmoIMG.transform.position.y);  
            }
        }
        else 
        {
            AddedAmmo = AmmoAmmount;
            //line that sends the ammo to the rigid weapon
            for (int i = 0; i < AmmoAmmount; i++)
            {
                var AmmoClone = Instantiate(AmmoIMG);
                AmmoClone.transform.SetParent(AmmoOBJ.transform);
                AmmoClone.transform.position = new Vector2(AmmoIMG.transform.position.x + (0.2f * i), AmmoIMG.transform.position.y);

            }

        }
        

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Players"))
        {

            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            AddAmmo();
            //Instantiate(OnContact, transform.localPosition, transform.localRotation);
            

        }

    }
}
