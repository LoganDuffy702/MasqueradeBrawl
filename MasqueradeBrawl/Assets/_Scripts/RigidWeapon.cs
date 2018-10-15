using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class RigidWeapon : MonoBehaviour {

	public int burstSize = 5;
	public float FireDelay=12;
    //public float Damage;
    
	public enum Player { Player1,Player2,Player3,Player4}
    public Player choosePlayr;

	public float ReloadSpeed = 1;
	bool CanShoot = true;
	bool showText = false;
	public GameObject TypeOfBullet;
    public int ShotGunBullets=4;

    public bool single = true;

	//public GameObject GunText;

    public int Ammo = 16;
    public GameObject AmmoPrefab;
    GameObject[] AmmoOBJ;
    public GameObject AmmoPos;
    //private Image Clips;
    public int removeAmount = 1;

    float fire;

    void Start()
    {

    }

	// Update is called once per frame
	void FixedUpdate () {

        switch (choosePlayr)
        {
            case Player.Player1:
                fire = Input.GetAxis("Fire1");
                if (fire > 0)
                {
                    if (CanShoot == true)
                    {
                        if (Ammo > 0)
                        {
                            StartCoroutine(Fire());
                            CanShoot = false;
                            StartCoroutine(Reload());

                            if (Ammo == 0)
                            {
                                Debug.Log("OUT OF Ammo");
                            }
                        }
                    }
                    else if (CanShoot == false)
                    {
                        if (showText == true)
                        {
                            //Debug.Log ("Reloading");
                            //StartCoroutine(ReloadFX());
                        }
                    }
                }
                break;
            case Player.Player2:
                fire = Input.GetAxis("Fire2");
                if (fire > 0)
                {
                    if (CanShoot == true)
                    {
                        if (Ammo > 0)
                        {
                            StartCoroutine(Fire());
                            CanShoot = false;
                            StartCoroutine(Reload());

                            

                            if (Ammo == 0)
                            {
                                Debug.Log("OUT OF Ammo");
                            }
                        }
                    }

                    else if (CanShoot == false)
                    {
                        if (showText == true)
                        {
                            //Debug.Log ("Reloading");
                            //StartCoroutine(ReloadFX());
                        }
                    }
                }
                break;
            case Player.Player3:
                break;
            case Player.Player4:
                break;
            default:
                break;
        }

        
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
                //Add sound effect here
                for (int x = 0; x < removeAmount; x++)
                {
                    gameObject.GetComponentInParent<PlayerAmmo>().RemoveClip(1);
                    Ammo -= 1;
                    
                }
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
