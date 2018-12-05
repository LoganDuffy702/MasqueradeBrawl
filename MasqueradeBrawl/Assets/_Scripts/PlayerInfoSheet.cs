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
    public bool MMNotSelected, FNotSelected, ButtNotSelected, PenNotSelected;
    public int count = 0;
    public GameObject LevelSelector;
    public bool Restart = false;
  
    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
        LoadMoonMan = false;
        LoadFoxy = false;
        LoadPenguin = false;
        LoadButtLady = false;

        MMNotSelected = false;
        FNotSelected = false;
        ButtNotSelected = false;
        PenNotSelected = false;

        Controller1 = false;
        Controller2 = false;
        Controller3 = false;
        Controller4 = false;

        //ActivePlayers();
        
    }
    public void Killold()
    {
        Destroy(gameObject);
    }
    public void NextLevelCounter(int Addplayer)
    {
        count += Addplayer;
        if (count > 1)
        {
            Debug.Log("Pick a level");
            LevelSelector.GetComponent<NextLevel>().ActivateLevel();
            LevelSelector.GetComponent<NextLevel>().LastPickerHor = "Horizontal1";
            LevelSelector.GetComponent<NextLevel>().LastPickerA = "Player1_A";
        }
        else
        {
            LevelSelector.GetComponent<NextLevel>().CanSelectLevel = false;
        }
        if (Restart == true)
        {
            count = 0;
            Restart = false;
        }
    }
    public void ActivePlayers()
    {
        
        if(SceneManager.GetActiveScene().name == "Static_Level")
        {
            Debug.Log("Static Level Loaded");
            //LoadPlayer();  
            CreatePlayers();
        }
        else if (SceneManager.GetActiveScene().name == "Falling_Level")
        {
            Debug.Log("Falling Level Loaded");
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
                MoonMan.GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal1";
                MoonMan.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player1;
                MoonMan.GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire1";
                Controller1 = false;
            }
            else if (Controller2 == true)
            {
                MoonMan.GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal2";
                MoonMan.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player2;
                MoonMan.GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire2";
                Controller2 = false;
            }
            else if (Controller3 == true)
            {
                MoonMan.GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal3";
                MoonMan.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player3;
                MoonMan.GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire3";
                Controller3 = false;

            }
            else if (Controller4 == true)
            {
                MoonMan.GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal4";
                MoonMan.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player4;
                MoonMan.GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire4";
                Controller4 = false;
            }

        }
        if (LoadButtLady == true)
        {
            GameObject ButtLady = Instantiate(Characters[1]);
            if (Controller1 == true)
            {
                ButtLady.GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal1";
                ButtLady.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player1;
                ButtLady.GetComponentInChildren<RigidWeapon>().enabled = true;
                ButtLady.GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire1";
                Controller1 = false;
            }
            if (Controller2 == true)
            {
                ButtLady.GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal2";
                ButtLady.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player2;
                ButtLady.GetComponentInChildren<RigidWeapon>().enabled = true;
                ButtLady.GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire2";

                Controller2 = false;
            }
            else if (Controller3 == true)
            {
                ButtLady.GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal3";
                ButtLady.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player3;
                ButtLady.GetComponentInChildren<RigidWeapon>().enabled = true;
                ButtLady.GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire3";

                Controller3 = false;
            }
            else if (Controller4 == true)
            {
                ButtLady.GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal4";
                ButtLady.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player4;
                ButtLady.GetComponentInChildren<RigidWeapon>().enabled = true;
                ButtLady.GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire4";

                Controller4 = false;
            }


        }
        if (LoadFoxy == true)
        {
            GameObject Foxy = Instantiate(Characters[2]);
            if (Controller1 == true)
            {
                Foxy.GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal1";
                Foxy.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player1;
                Foxy.GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire1";

                Controller1 = false;
            }
            else if (Controller2 == true)
            {
                Foxy.GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal2";
                Foxy.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player2;
                Foxy.GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire2";

                Controller2 = false;
            }
            else if (Controller3 == true)
            {
                Foxy.GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal3";
                Foxy.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player3;
                Foxy.GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire3";

                Controller3 = false;
            }
            else if (Controller4 == true)
            {
                Foxy.GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal4";
                Foxy.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player4;
                Foxy.GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire4";

                Controller4 = false;
            }


        }
        if (LoadPenguin == true)
        {
            GameObject Penguin = Instantiate(Characters[0]);
            if (Controller1 == true)
            {
                Penguin.GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal1";
                Penguin.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player1;
                Penguin.GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire1";

                Controller1 = false;
            }
            else if (Controller2 == true)
            {
                Penguin.GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal2";
                Penguin.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player2;
                Penguin.GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire2";

                Controller2 = false;
            }
            else if (Controller3 == true)
            {
                Penguin.GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal3";
                Penguin.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player3;
                Penguin.GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire3";

                Controller3 = false;
            }
            else if (Controller4 == true)
            {
                Penguin.GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal4";
                Penguin.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player4;
                Penguin.GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire4";

                Controller4 = false;
            }

        }

    }
}
