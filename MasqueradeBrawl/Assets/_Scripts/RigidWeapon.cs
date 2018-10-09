using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class RigidWeapon : MonoBehaviour {

	public int burstSize = 5;
	public float FireDelay=12;
    public float Damage;
    
	
	public float ReloadSpeed = 1;
	bool CanShoot = true;
	bool showText = false;
	public GameObject TypeOfBullet;
    public int ShotGunBullets=4;

    public bool single = true;

	public GameObject GunText;

    public int Ammo = 16;
    public GameObject AmmoPrefab;
    GameObject[] AmmoOBJ;
    GameObject AmmoPos;
    private Image Clips;
    private int AmmoClips = 16;
    public int removeAmount = 1;

    void Start()
    {

        AmmoPos = GameObject.Find("Ammo Section");
        //Debug.Log(AmmoPos.name);
        for (int i = 0; i < AmmoClips; i++)
        {
            var AmmoClone = Instantiate(AmmoPrefab);
            AmmoClone.transform.SetParent(AmmoPos.transform);
            AmmoClone.transform.localScale = new Vector2(0.015f, .12f);
            AmmoClone.transform.position = new Vector2(AmmoPos.transform.position.x + (0.2f * i), AmmoPos.transform.position.y);

        }

    }


	// Update is called once per frame
	void FixedUpdate () {
        var fire = Input.GetAxis("Fire1");
        Input.GetKeyDown(KeyCode.Space);

		if (fire > 0)
        {
			if (CanShoot == true) {
                if (Ammo > 0)
                {
                    StartCoroutine (Fire());
				    CanShoot = false;
				    StartCoroutine (Reload ());

                    for (int i = 0; i < removeAmount; i++)
                    {
                        Ammo -= 1;
                        RemoveClip(1);
                    }

                    if (Ammo == 0)
                    {
                        Debug.Log("OUT OF Ammo");
                    }
                }
            }
           
            else if (CanShoot == false)
            {
				if (showText==true) {
					//Debug.Log ("Reloading");
					//StartCoroutine(ReloadFX());
				}
            }
            
        }
	}

    public void RemoveClip(int amount)
    {
        AmmoOBJ = GameObject.FindGameObjectsWithTag("AmmoClips");
        //Debug.Log(Ammo + " " + AmmoOBJ[Ammo]);
        Destroy(AmmoOBJ[Ammo]);
    }

    //timer for reload speed 
    public IEnumerator Reload(){
		yield return new WaitForSeconds(ReloadSpeed);
		CanShoot = true;
	}
		
	//reload fx
	public IEnumerator ReloadFX(){
		//var ReloadText = (GameObject)Instantiate (GunText, transform.position, Quaternion.identity);//popup text
		yield return new WaitForSeconds(ReloadSpeed-0.3f);
		showText = false;
	}

	//Burst fire 
	public IEnumerator Fire(){
		float bulletDelay = 1 / FireDelay; //Decides the delay between each shot
		for (int i = 0; i < burstSize; i++)
		{
			if (single==true) {
                var bullet = Instantiate(TypeOfBullet);//Basic firing of bullet
                bullet.transform.position = transform.position;
                bullet.transform.rotation = transform.rotation;
            }
            else if (single == false) {
                for (int x = 0; x < ShotGunBullets; x++)
                {
                    var bullet1 = Instantiate(TypeOfBullet, transform.position, transform.rotation);//Basic firing of bullet
                    bullet1.GetComponent<Rigidbody2D>().velocity = bullet1.transform.TransformDirection(new Vector2(0, x));

                }
            }
			yield return new WaitForSeconds(bulletDelay); //Waits so many seconds before firing
		}
		showText = true;
	}

	//InvokeRepeating
}
