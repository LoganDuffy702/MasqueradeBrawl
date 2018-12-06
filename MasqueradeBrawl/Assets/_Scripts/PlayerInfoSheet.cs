using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerInfoSheet : MonoBehaviour {

    PlayerHealth HealthSelector;
    public List<GameObject> Characters;
    public bool LoadMoonMan, LoadButtLady, LoadPenguin, LoadFoxy;
    public bool MenC1, MenC2, MenC3, MenC4;
    public bool ButtC1, ButtC2, ButtC3, ButtC4;
    public bool PenC1, PenC2, PenC3, PenC4;
    public bool FoxC1, FoxC2, FoxC3, FoxC4;
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

        MenC1 = false;
        MenC2 = false;
        MenC3 = false;
        MenC4 = false;

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
            LevelSelector.GetComponent<NextLevel>().DeActive();
        }
        if (Restart == true)
        {
            count = 0;
            Restart = false;
        }
    }
    public void ActivePlayers()
    {

        if (SceneManager.GetActiveScene().name == "Static_Level")
        {
            Debug.Log("Static Level Loaded");
            //LoadPlayer();
            //Set the x,y spawns here for each player.
          
            CreateMoonMan();//and send it into this
            CreateButtLady();
            CreateFoxy();
            CreatePen();
        }
        else if (SceneManager.GetActiveScene().name == "Falling_Level")
        {
            Debug.Log("Falling Level Loaded");
            CreateMoonMan();//and send it into this
            CreateButtLady();
            CreateFoxy();
            CreatePen();
            //CreatePlayers();
        }
    }

    private void CreatePen()
    {
        GameObject penguin = GameObject.Find("_Penguin");

       
        if (LoadPenguin == true && PenC1 == true)
        {
            penguin.SetActive(true);
            penguin.GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal1";
            penguin.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player1;
            penguin.GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire1";

        }
        else if (LoadPenguin == true && PenC2 == true)
        {
            penguin.SetActive(true);
            penguin.GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal2";
            penguin.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player2;
            penguin.GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire2";

        }
        else if (LoadPenguin == true && PenC3 == true)
        {
            penguin.SetActive(true);
            penguin.GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal3";
            penguin.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player3;
            penguin.GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire3";

        }
        else if (LoadPenguin == true && PenC4 == true)
        {
            penguin.SetActive(true);
            penguin.GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal4";
            penguin.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player4;
            penguin.GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire4";
        }
        else
        {
            penguin.SetActive(false);
        }
    }

    private void CreateFoxy()
    {
        GameObject foxy = GameObject.Find("_Foxy");

        if (LoadFoxy == true && FoxC1 == true)
        {
            foxy.SetActive(true);
            foxy.GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal1";
            foxy.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player1;
            foxy.GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire1";

        }
        else if (LoadFoxy == true && FoxC2 == true)
        {
            foxy.SetActive(true);
            foxy.GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal2";
            foxy.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player2;
            foxy.GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire2";

        }
        else if (LoadFoxy == true && FoxC3 == true)
        {
            foxy.SetActive(true);
            foxy.GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal3";
            foxy.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player3;
            foxy.GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire3";

        }
        else if (LoadFoxy == true && FoxC4 == true)
        {
            foxy.SetActive(true);
            foxy.GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal4";
            foxy.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player4;
            foxy.GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire4";

        }
        else
        {
            foxy.SetActive(false);
        }
    }

    private void CreateButtLady()
    {
        GameObject buttlady = GameObject.Find("_ButtLady");

        if (LoadButtLady == true && ButtC1 == true)
        {
            buttlady.SetActive(true);
            buttlady.GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal1";
            buttlady.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player1;
           
            buttlady.GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire1";
           
        }
        else if (LoadButtLady == true && ButtC2 == true)
        {
            buttlady.SetActive(true);
            buttlady.GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal2";
            buttlady.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player2;
            buttlady.GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire2";

        }
        else if (LoadButtLady == true && ButtC3 == true)
        {
            buttlady.SetActive(true);
            buttlady.GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal3";
            buttlady.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player3;
            buttlady.GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire3";

        }
        else if (LoadButtLady == true && ButtC4 == true)
        {
            buttlady.SetActive(true);
            buttlady.GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal4";
            buttlady.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player4;
            buttlady.GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire4";

        }  
        else
        {
            buttlady.SetActive(false);
        }
    }

    public void CreateMoonMan()
    {
        GameObject moonman = GameObject.Find("_MoonMan");

        if (LoadMoonMan == true && MenC1 == true)
        {
            moonman.SetActive(true);
            moonman.GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal1";
            moonman.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player1;
            moonman.GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire1";  
        }
        else if (LoadMoonMan == true && MenC2 == true)
        {
            moonman.SetActive(true);
            moonman.GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal2";
            moonman.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player2;
            moonman.GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire2";
        }
        else if (LoadMoonMan == true && MenC3 == true)
        {
            moonman.SetActive(true);
            moonman.GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal3";
            moonman.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player3;
            moonman.GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire3";

        }
        else if (LoadMoonMan == true && MenC4 == true)
        {
            moonman.SetActive(true);
            moonman.GetComponent<PlayerMovementRedux>().PlayerController = "Horizontal4";
            moonman.GetComponentInChildren<AimTest>().PlayerController = AimTest.PlayerPos.Player4;
            moonman.GetComponentInChildren<RigidWeapon>().Playercontrols = "Fire4";
        }
        else
        {
            moonman.SetActive(false);
        }




    }
}
