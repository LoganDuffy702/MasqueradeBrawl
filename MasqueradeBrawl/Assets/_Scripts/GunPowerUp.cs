using UnityEngine;
using System.Collections;

public class GunPowerUp : MonoBehaviour {

    public GameObject BulletType;
    public GameObject WeaponFirepoint;

    public int numberOfBullets;
    public int roundSize;
    public float damage;
    public float reloadspeed;
    public float ShotSpacing;
    public bool No_shotgun;


    RigidWeapon Bullet;
	// Use this for initialization
	void Start () {
        Bullet = WeaponFirepoint.GetComponent<RigidWeapon>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void BulletRules()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            Bullet.TypeOfBullet = BulletType;
            Bullet.burstSize = roundSize;
            //Bullet.Damage = damage;
            Bullet.ShotGunMode = No_shotgun;
            Bullet.ReloadSpeed = reloadspeed;
            Bullet.ShotGunBullets = numberOfBullets;
            Bullet.FireDelay = ShotSpacing;
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<CircleCollider2D>().enabled = false;
            
        }
    }
}
