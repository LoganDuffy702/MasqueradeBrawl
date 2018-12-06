using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAmmo : MonoBehaviour {

    public int Count = 22;
    public GameObject AmmoPrefab;
    GameObject[] AmmoOBJ;
    public GameObject GunName;
    public GameObject AmmoPos;
    public int AmmoClips = 22;
    public int removeAmount = 1;
    public string AmmoClip;


    // Use this for initialization
    void Start () {
        
        for (int i = 0; i < AmmoClips; i++)
        {
            var AmmoClone = Instantiate(AmmoPrefab);

            AmmoClone.transform.SetParent(AmmoPos.transform);
            AmmoClone.transform.localScale = new Vector2(0.013f, .12f);
            AmmoClone.transform.position = new Vector2(AmmoPos.transform.position.x + (0.27f * i), AmmoPos.transform.position.y);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RemoveClip(int amount)
    {
        if (Count > 0)
        {
            //GameObject Gun = GameObject.Find(GunName.name);
            AmmoOBJ = GameObject.FindGameObjectsWithTag(AmmoClip);
            Destroy(AmmoOBJ[Count - 1]);
            Count -= amount;
        }
      
    }

    public void AddClip()
    {
        AmmoOBJ = GameObject.FindGameObjectsWithTag(AmmoClip);
        //GameObject Gun = GameObject.Find(GunName.name);

        for (int x = 0; x < Count; x++)
        {
            Destroy(AmmoOBJ[x]);
        }
        GunName.GetComponent<RigidWeapon>().Ammo = 22;
        Count = 22;
        Start();
        
        
    }
}
