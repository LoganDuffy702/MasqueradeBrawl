using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class MainMenuScript : MonoBehaviour {

    //public List<Button> ButtonList = new List<Button>();
    //public int count = 0;
    //public bool canInteract = true;
    public GameObject InfoSheet;
    
    public GameObject PlayerSheet;
    GameObject LvlSelc;

    public void Start()
    {
        LvlSelc = GameObject.Find("Canvas");
    }

    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    public void SelectPlayer()
    {
        if (Input.GetButtonDown("Submit") )
        {
            
            if (gameObject.GetComponent<Image>().color == Color.white)//Selected
            {
                if (gameObject.name == "MM")
                {
                    Debug.Log("MoonMan Selected");
                    InfoSheet.GetComponent<PlayerInfoSheet>().LoadMoonMan = true;
                }
                if (gameObject.name == "Foxy")
                {
                    Debug.Log("Foxy Selected");
                    InfoSheet.GetComponent<PlayerInfoSheet>().LoadFoxy = true;
                }
                if (gameObject.name == "Pen")
                {
                    Debug.Log("Pen Selected");
                    InfoSheet.GetComponent<PlayerInfoSheet>().LoadPenguin = true;
                }
                if (gameObject.name == "Butt")
                {
                    Debug.Log("Buttlady Selected");
                    InfoSheet.GetComponent<PlayerInfoSheet>().LoadButtLady = true;
                }

                LvlSelc.GetComponent<LevelSelect>().ToLevelSelect(1);
                gameObject.GetComponent<Image>().color = Color.gray;  

            }
            else if (gameObject.GetComponent<Image>().color == Color.gray)//Unselected
            {
                if (gameObject.name == "MM")
                {
                    Debug.Log("MoonMan Selected");
                    InfoSheet.GetComponent<PlayerInfoSheet>().LoadMoonMan = false;
                }
                if (gameObject.name == "Foxy")
                {
                    Debug.Log("Foxy Selected");
                    InfoSheet.GetComponent<PlayerInfoSheet>().LoadFoxy = false;
                }
                if (gameObject.name == "Pen")
                {
                    Debug.Log("Pen Selected");
                    InfoSheet.GetComponent<PlayerInfoSheet>().LoadPenguin = false;
                }
                if (gameObject.name == "Butt")
                {
                    Debug.Log("Buttlady Selected");
                    InfoSheet.GetComponent<PlayerInfoSheet>().LoadButtLady = false;
                }

                LvlSelc.GetComponent<LevelSelect>().ToLevelSelect(-1);
                gameObject.GetComponent<Image>().color = Color.white;
            }
     
        }
        else if (Input.GetButtonDown("Submit2"))
        {
            if (gameObject.GetComponent<Image>().color == Color.white)//Selected
            {
                LvlSelc.GetComponent<LevelSelect>().ToLevelSelect(1);
                gameObject.GetComponent<Image>().color = Color.gray;
            }
            else if (gameObject.GetComponent<Image>().color == Color.grey)//Unselected
            {
                LvlSelc.GetComponent<LevelSelect>().ToLevelSelect(-1);
                gameObject.GetComponent<Image>().color = Color.white;
            }
        }
        else if (Input.GetButtonDown("Submit3"))
        {
            if (gameObject.GetComponent<Image>().color == Color.white)//Selected
            {
                LvlSelc.GetComponent<LevelSelect>().ToLevelSelect(1);
                gameObject.GetComponent<Image>().color = Color.gray;
            }
            else if (gameObject.GetComponent<Image>().color == Color.grey)//Unselected
            {
                LvlSelc.GetComponent<LevelSelect>().ToLevelSelect(-1);
                gameObject.GetComponent<Image>().color = Color.white;
            }
        }
        else if (Input.GetButtonDown("Submit4"))
        {
            if (gameObject.GetComponent<Image>().color == Color.white)//Selected
            {
                LvlSelc.GetComponent<LevelSelect>().ToLevelSelect(1);
                gameObject.GetComponent<Image>().color = Color.gray;
            }
            else if (gameObject.GetComponent<Image>().color == Color.grey)//Unselected
            {
                LvlSelc.GetComponent<LevelSelect>().ToLevelSelect(-1);
                gameObject.GetComponent<Image>().color = Color.white;
            }
        }
        
    }
    
    
   
}
