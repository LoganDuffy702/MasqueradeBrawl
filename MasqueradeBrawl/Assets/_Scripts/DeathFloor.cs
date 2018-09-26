using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathFloor : MonoBehaviour {

    //GameObject Platform;
    //GameObject PowerUp;
    //PlayerHealth playerHP;
    void Start()
    {
        //Platform = GameObject.FindWithTag("DeathFloor");
        //PowerUp = GameObject.FindWithTag("PowerUp");
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("DeathFloor")) 
        {
            Destroy(gameObject);
        }
    }
}
