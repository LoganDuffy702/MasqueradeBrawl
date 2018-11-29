using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerInfoSheet : MonoBehaviour {

    PlayerHealth HealthSelector;
    public List<GameObject> Characters;
    public bool LoadMoonMan, LoadButtLady, LoadPenguin, LoadFoxy;
    public bool Controller1, Controller2, Controller3, Controller4;
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
        Controller1 = false;
        Controller2 = false;
        Controller3 = false;
        Controller4 = false;

        
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
            GameObject MoonMan = Instantiate(Characters[3]);
            if (Controller1 == true)
            {
                MoonMan.GetComponent<PlayerMovementRedux>().PlayerController = PlayerMovementRedux.PlayerPos.Player1;
                MoonMan.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player1;
                MoonMan.GetComponentInChildren<RigidWeapon>().choosePlayr = RigidWeapon.Player.Player1;
                Controller1 = false;
            }
            else if (Controller2 == true)
            {
                MoonMan.GetComponent<PlayerMovementRedux>().PlayerController = PlayerMovementRedux.PlayerPos.Player2;
                MoonMan.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player2;
                MoonMan.GetComponentInChildren<RigidWeapon>().choosePlayr = RigidWeapon.Player.Player2;
                Controller2 = false;
            }
            else if (Controller3 == true)
            {
                MoonMan.GetComponent<PlayerMovementRedux>().PlayerController = PlayerMovementRedux.PlayerPos.Player3;
                MoonMan.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player3;
                MoonMan.GetComponentInChildren<RigidWeapon>().choosePlayr = RigidWeapon.Player.Player3;
                Controller3 = false;
            
            }
            else if (Controller4 == true)
            {
                MoonMan.GetComponent<PlayerMovementRedux>().PlayerController = PlayerMovementRedux.PlayerPos.Player4;
                MoonMan.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player4;
                MoonMan.GetComponentInChildren<RigidWeapon>().choosePlayr = RigidWeapon.Player.Player4;
                Controller4 = false;
            }
          
        }
        if (LoadButtLady == true)
        {
            GameObject ButtLady = Instantiate(Characters[1]);
            if (Controller1 == true)
            {
                ButtLady.GetComponent<PlayerMovementRedux>().PlayerController = PlayerMovementRedux.PlayerPos.Player1;
                ButtLady.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player1;
                ButtLady.GetComponentInChildren<RigidWeapon>().choosePlayr = RigidWeapon.Player.Player1;
                Controller1 = false;
            }
            else if (Controller2 == true)
            {
                ButtLady.GetComponent<PlayerMovementRedux>().PlayerController = PlayerMovementRedux.PlayerPos.Player2;
                ButtLady.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player2;
                ButtLady.GetComponentInChildren<RigidWeapon>().choosePlayr = RigidWeapon.Player.Player2;

                Controller2 = false;
            }
            else if (Controller3 == true)
            {
                ButtLady.GetComponent<PlayerMovementRedux>().PlayerController = PlayerMovementRedux.PlayerPos.Player3;
                ButtLady.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player3;
                ButtLady.GetComponentInChildren<RigidWeapon>().choosePlayr = RigidWeapon.Player.Player3;

                Controller3 = false;
            }
            else if (Controller4 == true)
            {
                ButtLady.GetComponent<PlayerMovementRedux>().PlayerController = PlayerMovementRedux.PlayerPos.Player4;
                ButtLady.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player4;
                ButtLady.GetComponentInChildren<RigidWeapon>().choosePlayr = RigidWeapon.Player.Player4;

                Controller4 = false;
            }
  
           
        }
        if (LoadFoxy == true)
        {
            GameObject Foxy = Instantiate(Characters[2]);
            if (Controller1 == true)
            {
                Foxy.GetComponent<PlayerMovementRedux>().PlayerController = PlayerMovementRedux.PlayerPos.Player1;
                Foxy.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player1;
                Foxy.GetComponentInChildren<RigidWeapon>().choosePlayr = RigidWeapon.Player.Player1;

                Controller1 = false;
            }
            else if (Controller2 == true)
            {
                Foxy.GetComponent<PlayerMovementRedux>().PlayerController = PlayerMovementRedux.PlayerPos.Player2;
                Foxy.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player2;
                Foxy.GetComponentInChildren<RigidWeapon>().choosePlayr = RigidWeapon.Player.Player2;

                Controller2 = false;
            }
            else if (Controller3 == true)
            {
                Foxy.GetComponent<PlayerMovementRedux>().PlayerController = PlayerMovementRedux.PlayerPos.Player3;
                Foxy.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player3;
                Foxy.GetComponentInChildren<RigidWeapon>().choosePlayr = RigidWeapon.Player.Player3;

                Controller3 = false;
            }
            else if (Controller4 == true)
            {
                Foxy.GetComponent<PlayerMovementRedux>().PlayerController = PlayerMovementRedux.PlayerPos.Player4;
                Foxy.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player4;
                Foxy.GetComponentInChildren<RigidWeapon>().choosePlayr = RigidWeapon.Player.Player4;

                Controller4 = false;
            }
         
     
        }
        if (LoadPenguin == true)
        {
            GameObject Penguin = Instantiate(Characters[0]);
            if (Controller1 == true)
            {
                Penguin.GetComponent<PlayerMovementRedux>().PlayerController = PlayerMovementRedux.PlayerPos.Player1;
                Penguin.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player1;
                Penguin.GetComponentInChildren<RigidWeapon>().choosePlayr = RigidWeapon.Player.Player1;

                Controller1 = false;
            }
            else if (Controller2 == true)
            {
                Penguin.GetComponent<PlayerMovementRedux>().PlayerController = PlayerMovementRedux.PlayerPos.Player2;
                Penguin.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player2;
                Penguin.GetComponentInChildren<RigidWeapon>().choosePlayr = RigidWeapon.Player.Player2;

                Controller2 = false;
            }
            else if (Controller3 == true)
            {
                Penguin.GetComponent<PlayerMovementRedux>().PlayerController = PlayerMovementRedux.PlayerPos.Player3;
                Penguin.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player3;
                Penguin.GetComponentInChildren<RigidWeapon>().choosePlayr = RigidWeapon.Player.Player3;

                Controller3 = false;
            }
            else if (Controller4 == true)
            {
                Penguin.GetComponent<PlayerMovementRedux>().PlayerController = PlayerMovementRedux.PlayerPos.Player4;
                Penguin.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player4;
                Penguin.GetComponentInChildren<RigidWeapon>().choosePlayr = RigidWeapon.Player.Player4;

                Controller4 = false;
            }
         
        }

    }
}
