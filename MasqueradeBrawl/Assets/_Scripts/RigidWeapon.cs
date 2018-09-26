using UnityEngine;
using System.Collections;

public class RigidWeapon : MonoBehaviour {

	public int burstSize = 5;
	public float Damage = 10;
	public float FireDelay=12;
	
	public float ReloadSpeed = 1;
	bool CanShoot = true;
	bool showText = false;
	public GameObject TypeOfBullet;
	public int BulletSpeed = 20;
    public int ShotGunBullets=4;

    public bool single = true;

	public GameObject GunText;
    
    void Start()
    {
       
    }

	// Update is called once per frame
	void Update () {
        var fire = Input.GetAxis("Fire1");

		if (fire > 0)
        {
			if (CanShoot == true) {
				StartCoroutine (FireBurst ());
				CanShoot = false;
				StartCoroutine (Reload ());
				
			} else if (CanShoot == false) {
				if (showText==true) {
					Debug.Log ("Reloading");
					//StartCoroutine(ReloadFX());
				}
            } 
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

	//The firing of the bullet, this only tells the system which direction to shoot not the functionallity of the bullet.
	void Fire(){
        var bullet = (GameObject)Instantiate(TypeOfBullet, transform.position, transform.rotation);//Basic firing of bullet
        bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.TransformDirection(new Vector2(BulletSpeed,0));
		//Destroy (bullet, 1f);
	}

	void ShotGun(){
		

        for (int i = 0; i < ShotGunBullets; i++)
        {
            var bullet1 = (GameObject)Instantiate(TypeOfBullet, transform.position, transform.rotation);//Basic firing of bullet
            bullet1.GetComponent<Rigidbody2D>().velocity = bullet1.transform.TransformDirection(new Vector2(BulletSpeed,i));
            
            //Destroy(bullet1, 1f);
        }
    }

	//Burst fire 
	public IEnumerator FireBurst(){
		float bulletDelay = 1 / FireDelay; //Decides the delay between each shot
		for (int i = 0; i < burstSize; i++)
		{
			if (single==true) {
				Fire();
			}else if (single == false) {
				ShotGun();
			}
			yield return new WaitForSeconds(bulletDelay); //Waits so many seconds before firing
		}
		showText = true;
	}

	//InvokeRepeating
}
