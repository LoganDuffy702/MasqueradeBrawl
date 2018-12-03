﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1Selection : MonoBehaviour {

    public List<GameObject> PlayersList;
    public bool activateMe,Canmove,CanRemove;

    public string PlayerSelect;
    public string PlayerRemove;
    public string PlayerVer;


    public GameObject InfoSheet;
    PlayerInfoSheet LevelInformation;

    bool AddController;
    public AudioSource SelectSound, Movesound, RemoveSound;

    GameObject LvlSelc;
    int currentNum = 0;
    bool Nextbutton;

    public void Start()
    {
        LevelInformation = InfoSheet.GetComponent<PlayerInfoSheet>();
        PlayersList[0].GetComponent<Image>().color = Color.gray;
        for (int i = 1; i < PlayersList.Count; i++)
        {
            PlayersList[i].SetActive(false);
        }
    }
    private void Update()
    {
        if (activateMe == true)
        {
            PlayersList[0].GetComponent<Image>().color = Color.white;
            
            Canmove = true; 
        }
        else
        {
            Canmove = false;
        }

        if (Canmove == true)
        {
            //Added and remove functions-----------------------------------------------------
            if (Input.GetButtonDown(PlayerSelect))//Player Selected
            {
                activateMe = false;
                CanRemove = true;
                LevelInformation.NextLevelCounter(1);
                SelectSound.Play();
                string P_name = PlayersList[currentNum].name;
                //PlayersList[currentNum].GetComponent<Image>().color = Color.gray;
                Debug.Log("Player1 Picked " + P_name);
                AddPlayer(P_name, PlayersList[currentNum]);
            }

            if (Input.GetAxis(PlayerVer) == 0)
            {
                Nextbutton = true;
                
            }

            if (Input.GetAxis(PlayerVer) > 0.2 && Nextbutton == true)
            {
                Nextbutton = false;
                currentNum += 1;
                
                if (currentNum >= PlayersList.Count)
                {
                    currentNum = 1;//change to 1? try to skip unselected screen.
                }
                else if (currentNum < 0)
                {
                    currentNum = PlayersList.Count;
                }

                for (int i = 0; i < currentNum; i++)
                {
                    PlayersList[i].SetActive(false);
                }
                PlayersList[currentNum].SetActive(true);
                for (int i = currentNum + 1; i <= PlayersList.Count-1; i++)
                {
                    PlayersList[i].SetActive(false);
                }
                Movesound.pitch += .2f;
                Movesound.Play();

            }

            else if (Input.GetAxis(PlayerVer) < -0.2 && Nextbutton == true)
            {
                Nextbutton = false;
                currentNum -= 1;
               
                if (currentNum >= PlayersList.Count)
                {
                    currentNum = 0;
                    
                }
                else if (currentNum < 1)
                {
                    currentNum = PlayersList.Count - 1;
                    
                }
                
                for (int i = 0; i <= currentNum; i++)
                {
                    PlayersList[i].SetActive(false);
                }
                PlayersList[currentNum].SetActive(true);
                for (int i = currentNum+1; i <= PlayersList.Count-1; i++)
                {
                    PlayersList[i].SetActive(false);
                }

                Movesound.pitch -= .2f;
                Movesound.Play();
            }
        }

        if (Canmove == false && CanRemove == true)
        {
            if (Input.GetButtonDown(PlayerRemove))
            {
                RemoveSound.Play();
                LevelInformation.NextLevelCounter(-1);
                string P_name = PlayersList[currentNum].name;
                PlayersList[currentNum].GetComponent<Image>().color = Color.white;
                Debug.Log("Player1 UnPicked " + P_name);
                RemovePlayer(P_name, PlayersList[currentNum]);
                activateMe = true;
                CanRemove = false;
            }
            
        }

    }

    public void AddPlayer(string PlayerName, GameObject currentBtn)
    {

        if (PlayerName == "MM" && LevelInformation.MMNotSelected == false)
        {
            Debug.Log("MoonMan Selected");

            LevelInformation.LoadMoonMan = true;
            LevelInformation.Controller1 = true;
            LevelInformation.MMNotSelected = true;

            currentBtn.GetComponent<Image>().color = Color.gray;

        }
        else if (PlayerName == "MM" && LevelInformation.MMNotSelected == true)
        {
            Debug.Log("MoonMan already Selected");
            activateMe = true;
            LevelInformation.NextLevelCounter(-1);
        }
        ///--------------------------------------------------------

        if (PlayerName == "Foxy" && LevelInformation.FNotSelected == false)
        {
            Debug.Log("Foxy Selected");
            
            LevelInformation.LoadFoxy = true;
            LevelInformation.Controller1 = true;
            currentBtn.GetComponent<Image>().color = Color.gray;


            LevelInformation.FNotSelected = true;
        }
        else if (PlayerName == "Foxy" && LevelInformation.FNotSelected == true)
        {
            Debug.Log("Foxy already Selected");
            activateMe = true;
            LevelInformation.NextLevelCounter(-1);
        }
        //-----------------------------------------------------------

        if (PlayerName == "Pen" && LevelInformation.PenNotSelected == false)
        {
            Debug.Log("Pen Selected");
        
            LevelInformation.LoadPenguin = true;
            LevelInformation.Controller1 = true;
            LevelInformation.PenNotSelected = true;

            currentBtn.GetComponent<Image>().color = Color.gray;
        }
        else if (PlayerName == "Pen" && LevelInformation.PenNotSelected == true)
        {
            Debug.Log("Penguin already Selected");
            activateMe = true;
            LevelInformation.NextLevelCounter(-1);
        }
        //-----------------------------------------------------------

        if (PlayerName == "Butt" && LevelInformation.ButtNotSelected == false)
        {
            Debug.Log("Buttlady Selected");
          
            LevelInformation.LoadButtLady = true;
            LevelInformation.Controller1 = true;
            LevelInformation.ButtNotSelected = true;

            currentBtn.GetComponent<Image>().color = Color.gray;
        }
        else if (PlayerName == "Butt" && LevelInformation.ButtNotSelected == true)
        {
            Debug.Log("Butt already Selected");
            activateMe = true;
            LevelInformation.NextLevelCounter(-1);
        }

    }

    public void RemovePlayer(string PlayerName, GameObject currentbtn)
    {
        if (PlayerName == "MM" && LevelInformation.MMNotSelected == true)
        {
            currentbtn.GetComponent<Image>().color = Color.white;
            Debug.Log("MoonMan UnSelected");

            LevelInformation.LoadMoonMan = false;
            LevelInformation.Controller1 = false;
         
            LevelInformation.MMNotSelected = false;
        }
        if (PlayerName == "Foxy" && LevelInformation.FNotSelected == true)
        {
            Debug.Log("Foxy UnSelected");
            
            currentbtn.GetComponent<Image>().color = Color.white;

            LevelInformation.LoadFoxy = false;
            LevelInformation.Controller1 = false;
            LevelInformation.FNotSelected = false;

        }
        if (PlayerName == "Pen" && LevelInformation.PenNotSelected == true)
        {
            Debug.Log("Pen UnSelected");
           
            currentbtn.GetComponent<Image>().color = Color.white;

            LevelInformation.LoadPenguin = false;
            LevelInformation.Controller1 = false;
            LevelInformation.PenNotSelected = false;

        }
        if (PlayerName == "Butt" && LevelInformation.ButtNotSelected == true)
        {
            Debug.Log("Buttlady UnSelected");

            currentbtn.GetComponent<Image>().color = Color.white;

            LevelInformation.LoadButtLady = false;
            LevelInformation.Controller1 = false;
            LevelInformation.ButtNotSelected = false;

        }
    }
}