using UnityEngine;
using System.Collections;

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

	// Update is called once per frame
	void FixedUpdate () {
        var fire = Input.GetAxis("Fire1");
        Input.GetKeyDown(KeyCode.Space);

		if (Input.GetKeyDown(KeyCode.Space))//fire > 0
        {
			if (CanShoot == true) {
				StartCoroutine (Fire());
				CanShoot = false;
				StartCoroutine (Reload ());	
			}
            else if (CanShoot == false)
            {
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
