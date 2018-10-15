using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAmmo : MonoBehaviour {

    public int Ammo = 16;
    public GameObject AmmoPrefab;
    GameObject[] AmmoOBJ;
    public GameObject GunName;
    public GameObject AmmoPos;
    private int AmmoClips = 16;
    public int removeAmount = 1;
    public string AmmoClip;


    // Use this for initialization
    void Start () {
        for (int i = 0; i < AmmoClips; i++)
        {
            var AmmoClone = Instantiate(AmmoPrefab);

            AmmoClone.transform.SetParent(AmmoPos.transform);
            AmmoClone.transform.localScale = new Vector2(0.015f, .12f);
            AmmoClone.transform.position = new Vector2(AmmoPos.transform.position.x + (0.2f * i), AmmoPos.transform.position.y);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RemoveClip(int amount)
    {
        if (Ammo > 0)
        {
            //GameObject Gun = GameObject.Find(GunName.name);
            AmmoOBJ = GameObject.FindGameObjectsWithTag(AmmoClip);
            Destroy(AmmoOBJ[Ammo - 1]);
            Ammo -= amount;
        }
        else
        {
            
            Debug.Log("OUT OF AMMO");
            
        }
    }

    public void AddClip()
    {
        AmmoOBJ = GameObject.FindGameObjectsWithTag(AmmoClip);
        GameObject Gun = GameObject.Find(GunName.name);

        for (int x = 0; x < Ammo; x++)
        {
            Destroy(AmmoOBJ[x]);
        }
        Gun.GetComponent<RigidWeapon>().Ammo = 16;
        Ammo = 16;
        Start();
        
        
    }
}
