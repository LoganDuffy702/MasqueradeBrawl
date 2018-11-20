using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerInfoSheet : MonoBehaviour {

    PlayerHealth HealthSelector;
    public List<GameObject> Characters;
    public bool LoadMoonMan, LoadButtLady, LoadPenguin, LoadFoxy;
    public int PlayerNumber;

    public void P_Health_Info()
    {
            
            HealthSelector = GameObject.Find("_MoonMan").GetComponent<PlayerHealth>();
            HealthSelector.P_HP = PlayerHealth.Players.M;
            Debug.Log("LoadedHP");

    }
    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
        LoadMoonMan = false;
        LoadFoxy = false;
        LoadPenguin = false;
        LoadButtLady = false;
        ActivePlayers();
        
    }
    public void ActivePlayers()
    {
        
        if(SceneManager.GetActiveScene().name == "Static_Level")
        {
            Debug.Log("Static Level Loaded");
            //LoadPlayer();  
            CreatePlayers();
        }
    }
   
    public void CreatePlayers()
    {
        //In here we will instantate the number charactsrs, then add the names of the players to the winner scripts 
        //PlayerList List so it can send player info to the camera and other stuff.
        if (LoadMoonMan == true)
        {

        }
        if (LoadButtLady == true)
        {

        }
        if (LoadFoxy == true)
        {

        }
        if (LoadPenguin == true)
        {

        }
        GameObject Player1 = Instantiate(Characters[0]);
        //Player1.GetComponent<PlayerMovementRedux>().PlayerController = 0;
        GameObject Player2 = Instantiate(Characters[1]);
        //Player2.GetComponent<PlayerMovementRedux>().PlayerController = 0;
        GameObject Player3 = Instantiate(Characters[2]);
        //Player3.GetComponent<PlayerMovementRedux>().PlayerController = 0;
        GameObject Player4 = Instantiate(Characters[3]);
        //Player4.GetComponent<PlayerMovementRedux>().PlayerController = 0;

    }
}
