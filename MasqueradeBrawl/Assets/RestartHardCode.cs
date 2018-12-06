using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartHardCode : MonoBehaviour {


    GameObject killcode;
    private void Start()
    {
        killcode = GameObject.Find("PlayerInfo");
    }
    //Update is called once per frame
    void Update () {
        if (Input.GetAxis("Fire1") > 0  && Input.GetButtonDown("Player1_A") == true && Input.GetButtonDown("Cancel1"))
        {
            killcode.GetComponent<PlayerInfoSheet>().Killold();
            SceneManager.LoadScene("_Intro", LoadSceneMode.Single);
            
        }
        if (Input.GetAxis("Fire2") > 0 && Input.GetButtonDown("Player2_A") == true && Input.GetButtonDown("Cancel2"))
        {
            killcode.GetComponent<PlayerInfoSheet>().Killold();
            SceneManager.LoadScene("_Intro", LoadSceneMode.Single);
           
        }
        if (Input.GetAxis("Fire3") > 0 && Input.GetButtonDown("Player3_A") == true && Input.GetButtonDown("Cancel3"))
        {
            killcode.GetComponent<PlayerInfoSheet>().Killold();
            SceneManager.LoadScene("_Intro", LoadSceneMode.Single);
           
        }
        if (Input.GetAxis("Fire4") > 0 && Input.GetButtonDown("Player4_A") == true && Input.GetButtonDown("Cancel4"))
        {
            killcode.GetComponent<PlayerInfoSheet>().Killold();
            SceneManager.LoadScene("_Intro", LoadSceneMode.Single);
            
        }
    }
}
