using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerInfoSheet : MonoBehaviour {

    PlayerHealth HealthSelector;
    public List<GameObject> Characters;
    //public string MoonMan, Penguin, ButtLady, Foxy;
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
    //public void LoadPlayer()
    //{

    //    if (PlayerNumber == 1)
    //    {

    //    }
    //    if (Name.name == "_MoonMan")
    //    {
    //        GameObject.Find("_MoonMan").GetComponent<PlayerHealth>().P_HP = 0;
    //        //GameObject.Find("_MoonMan").GetComponent<PlayerMovementRedux>().PlayerController = PlayerNumber;
    //        GameObject.Find("_MoonMan_Anim").GetComponent<SpriteRenderer>().enabled = true;
    //    }
    //    else if (Name.name == "_Penguin")
    //    {
    //        GameObject.Find("_Penguin_Anim").GetComponent<SpriteRenderer>().enabled = true;
    //    }
    //    else if (Name.name == "_ButtLady")
    //    {
    //        GameObject.Find("_ButtLady_Anim").GetComponent<SpriteRenderer>().enabled = true;
    //    }
    //    else if (Name.name == "_Foxy")
    //    {
    //        GameObject.Find("_Foxy_Anim").GetComponent<SpriteRenderer>().enabled = true;
    //    }
        
    //}
    public void CreatePlayers()
    {
        //In here we will instantate the number charactsrs, then add the names of the players to the winner scripts 
        //PlayerList List so it can send player info to the camera and other stuff.
        GameObject Player1 = Instantiate(Characters[0]);
        //Player1.GetComponent<PlayerMovementRedux>().PlayerController = 0;
        GameObject Player2 = Instantiate(Characters[1]);
        Player2.GetComponent<PlayerMovementRedux>().PlayerController = 0;
        GameObject Player3 = Instantiate(Characters[2]);
        //Player3.GetComponent<PlayerMovementRedux>().PlayerController = 0;
        GameObject Player4 = Instantiate(Characters[3]);
        //Player4.GetComponent<PlayerMovementRedux>().PlayerController = 0;

    }
}
