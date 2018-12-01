using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class RigidWeaponPen : MonoBehaviour {

	public int burstSize = 5;
	public float FireDelay=12;
    //public float Damage;

    public AudioSource Gunsound;
    
	

	public float ReloadSpeed = 1;
    public string Playercontrols;
	bool CanShoot = true;
	bool showText = false;
	public GameObject TypeOfBullet;
    public int ShotGunBullets=4;

    public bool ShotGunMode = true;

	//public GameObject GunText;

    public int Ammo = 22;
    //public GameObject AmmoPrefab;
    private Vector3 temp;
    GameObject[] AmmoOBJ;
    public GameObject PlayerGun;
    public GameObject AmmoPos;
    //private Image Clips;
    public int removeAmount = 1;

    float fire;

    void Start()
    {
        //Debug.Log(PlayerGun.name);
        Gunsound = gameObject.GetComponent<AudioSource>();

    }

	// Update is called once per frame
	void FixedUpdate () {

        
        if (Input.GetAxis(Playercontrols) > 0)
        {
            if (CanShoot == true)
            {

                if (Ammo > 0)
                {
                    Debug.Log("Player1 Fires");
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
        temp = PlayerGun.transform.localPosition;
        float bulletDelay = 1 / FireDelay; //Decides the delay between each shot
		for (int i = 0; i < burstSize; i++)
		{
            PlayerGun.transform.localPosition = new Vector3(Mathf.Abs(temp.x / 3), temp.y, temp.z);
            Gunsound.Play();
            if (ShotGunMode==false) {
                
                for (int x = 0; x < removeAmount; x++)
                {
                    gameObject.GetComponentInParent<PlayerAmmo>().RemoveClip(1);
                    Ammo -= 1;
                    
                }
                var bullet = Instantiate(TypeOfBullet);//Basic firing of bullet
                bullet.transform.position = transform.position;
                bullet.transform.rotation = transform.rotation;
                
            }
            else if (ShotGunMode == true) {
                for (int w = 0; w < ShotGunBullets; w++)
                {
                    for (int x = 0; x < removeAmount; x++)
                    {
                        gameObject.GetComponentInParent<PlayerAmmo>().RemoveClip(1);
                        Ammo -= 1;

                    }
                    var bullet1 = Instantiate(TypeOfBullet, transform.position, transform.rotation);//Basic firing of bullet
                    bullet1.transform.Rotate(0, 0, Random.Range(-15, 15));
                    //bullet1.GetComponent<Rigidbody2D>().velocity = bullet1.transform.TransformDirection(new Vector2(0, x));

                }
            }
            yield return new WaitForSeconds(bulletDelay); //Waits so many seconds before firing
            //Add sound effect here
            PlayerGun.transform.localPosition = temp;
            yield return new WaitForSeconds(bulletDelay);
            
        }
		showText = true;
	}

	//InvokeRepeating
}
