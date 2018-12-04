using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TempararyLoad : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Fire1") > 0 && Input.GetButtonDown("Player1_A") == true )
        {
            SceneManager.LoadScene("Static_Level", LoadSceneMode.Single);
        }
        else if (Input.GetAxis("Fire1") > 0 && Input.GetButtonDown("Cancel1") == true)
        {
            SceneManager.LoadScene("Falling_Level", LoadSceneMode.Single);
        }
        if (Input.GetAxis("Fire2") > 0 && Input.GetButtonDown("Player2_A") == true )
        {
            SceneManager.LoadScene("Static_Level", LoadSceneMode.Single);
        }
        else if (Input.GetAxis("Fire2") > 0 && Input.GetButtonDown("Cancel2") == true)
        {
            SceneManager.LoadScene("Falling_Level", LoadSceneMode.Single);
        }
        if (Input.GetAxis("Fire3") > 0 && Input.GetButtonDown("Player3_A") == true)
        {
            SceneManager.LoadScene("Static_Level", LoadSceneMode.Single);
        }
        else if (Input.GetAxis("Fire3") > 0 && Input.GetButtonDown("Cancel3") == true)
        {
            SceneManager.LoadScene("Falling_Level", LoadSceneMode.Single);
        }
        if (Input.GetAxis("Fire4") > 0 && Input.GetButtonDown("Player4_A") == true)
        {
            SceneManager.LoadScene("Static_Level", LoadSceneMode.Single);
        }
        else if (Input.GetAxis("Fire4") > 0 && Input.GetButtonDown("Cancel4") == true)
        {
            SceneManager.LoadScene("Falling_Level", LoadSceneMode.Single);
        }
    }
}
