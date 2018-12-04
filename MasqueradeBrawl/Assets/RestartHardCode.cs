using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartHardCode : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Fire1") > 0  && Input.GetButtonDown("Player1_A") == true && Input.GetButtonDown("Cancel1"))
        {
            SceneManager.LoadScene("_CharSelect", LoadSceneMode.Single);
        }
        if (Input.GetAxis("Fire2") > 0 && Input.GetButtonDown("Player2_A") == true && Input.GetButtonDown("Cancel2"))
        {
            SceneManager.LoadScene("_CharSelect", LoadSceneMode.Single);
        }
        if (Input.GetAxis("Fire3") > 0 && Input.GetButtonDown("Player3_A") == true && Input.GetButtonDown("Cancel3"))
        {
            SceneManager.LoadScene("_CharSelect", LoadSceneMode.Single);
        }
        if (Input.GetAxis("Fire4") > 0 && Input.GetButtonDown("Player4_A") == true && Input.GetButtonDown("Cancel4"))
        {
            SceneManager.LoadScene("_CharSelect", LoadSceneMode.Single);
        }
    }
}
