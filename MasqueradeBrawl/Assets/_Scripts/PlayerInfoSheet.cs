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
            //Set the x,y spawns here for each player.
            CreatePlayers();//and send it into this
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
        for (int i = 0; i < Characters.Count; i++)
        {
            Characters[i].SetActive(false);
            Debug.Log("Disable " + i);
        }
        if (LoadMoonMan == true)
        {
            //GameObject MoonMan = Instantiate(Characters[3]);
            Characters[3].SetActive(true);
            if (Controller1 == true)
            {
                Characters[3].GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal1";
                Characters[3].GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player1;
                Characters[3].GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire1";
                Controller1 = false;
            }
            else if (Controller2 == true)
            {
                Characters[3].GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal2";
                Characters[3].GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player2;
                Characters[3].GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire2";
                Controller2 = false;
            }
            else if (Controller3 == true)
            {
                Characters[3].GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal3";
                Characters[3].GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player3;
                Characters[3].GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire3";
                Controller3 = false;

            }
            else if (Controller4 == true)
            {
                Characters[3].GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal4";
                Characters[3].GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player4;
                Characters[3].GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire4";
                Controller4 = false;
            }

        }
        else if (LoadMoonMan == false)
        {
            Characters[3].SetActive(false);
        }

        if (LoadButtLady == true)
        {
            //GameObject ButtLady = Instantiate(Characters[1]);
            Characters[1].SetActive(true);
            if (Controller1 == true)
            {
                Characters[1].GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal1";
                Characters[1].GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player1;
                Characters[1].GetComponentInChildren<RigidWeapon>().enabled = true;
                Characters[1].GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire1";
                Controller1 = false;
            }
            if (Controller2 == true)
            {
                Characters[1].GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal2";
                Characters[1].GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player2;
                Characters[1].GetComponentInChildren<RigidWeapon>().enabled = true;
                Characters[1].GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire2";

                Controller2 = false;
            }
            else if (Controller3 == true)
            {
                Characters[1].GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal3";
                Characters[1].GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player3;
                Characters[1].GetComponentInChildren<RigidWeapon>().enabled = true;
                Characters[1].GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire3";

                Controller3 = false;
            }
            else if (Controller4 == true)
            {
                Characters[1].GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal4";
                Characters[1].GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player4;
                Characters[1].GetComponentInChildren<RigidWeapon>().enabled = true;
                Characters[1].GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire4";

                Controller4 = false;
            }


        }
        else if (LoadButtLady == false)
        {
            Characters[1].SetActive(false);
        }
        if (LoadFoxy == true)
        {
            //GameObject Foxy = Instantiate(Characters[2]);
            Characters[2].SetActive(true);
            if (Controller1 == true)
            {
                Characters[2].GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal1";
                Characters[2].GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player1;
                Characters[2].GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire1";

                Controller1 = false;
            }
            else if (Controller2 == true)
            {
                Characters[2].GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal2";
                Characters[2].GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player2;
                Characters[2].GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire2";

                Controller2 = false;
            }
            else if (Controller3 == true)
            {
                Characters[2].GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal3";
                Characters[2].GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player3;
                Characters[2].GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire3";

                Controller3 = false;
            }
            else if (Controller4 == true)
            {
                Characters[2].GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal4";
                Characters[2].GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player4;
                Characters[2].GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire4";

                Controller4 = false;
            }


        }
        else if (LoadFoxy == false)
        {
            Characters[2].SetActive(false);
        }
        if (LoadPenguin == true)
        {
            //GameObject Penguin = Instantiate(Characters[0]);
            Characters[0].SetActive(true);
            if (Controller1 == true)
            {
                Characters[0].GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal1";
                Characters[0].GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player1;
                Characters[0].GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire1";

                Controller1 = false;
            }
            else if (Controller2 == true)
            {
                Characters[0].GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal2";
                Characters[0].GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player2;
                Characters[0].GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire2";

                Controller2 = false;
            }
            else if (Controller3 == true)
            {
                Characters[0].GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal3";
                Characters[0].GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player3;
                Characters[0].GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire3";

                Controller3 = false;
            }
            else if (Controller4 == true)
            {
                Characters[0].GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal4";
                Characters[0].GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player4;
                Characters[0].GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire4";

                Controller4 = false;
            }

        }
        if (LoadPenguin == false)
        {
            Characters[0].SetActive(false);
        }

    }
}
