//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine.SceneManagement;
//using UnityEngine.UI;
//using UnityEngine;

//public class MainMenuScript : MonoBehaviour {

//    //public List<Button> ButtonList = new List<Button>();
//    //public int count = 0;
//    //public bool canInteract = true;
//    public GameObject InfoSheet;
//    //public GameObject TEst;
//    //public GameObject PlayerSheet;

//    public string PlayerSelect;
//    public string PlayerRemove;
//    public string PlayerHor;

//    public SpriteState HighlightedSprt = new SpriteState();
//    //bool AddController;
//    public AudioSource SelectSound, Movesound, RemoveSound;

//    public GameObject LevelPicker;

//    //string PlayerName;
    
//    bool MMNotSelected, FNotSelected, ButtNotSelected, PenNotSelected;
//    GameObject LvlSelc;
//    public List<Button> btns;
//    int currentNum = 0;
//    bool Nextbutton,Nextbutton2;

//    public void Start()
//    {
//        LvlSelc = GameObject.Find("Canvas");
//        //AddController = false;
//        //Debug.Log(PlayerSelect);
        
//    }

//    public void ExitGame()
//    {
//        //UnityEditor.EditorApplication.isPlaying = false;
//        Application.Quit();
//    }
////    public void RemovePlayer(string PlayerName)
////    {
////        if (PlayerName == "MM" && MMNotSelected == true)
////        {
////            LvlSelc.GetComponent<LevelSelect>().ToLevelSelect(-1);
////            btns[currentNum].GetComponent<Image>().color = Color.white;
////            Debug.Log("MoonMan UnSelected");

////            InfoSheet.GetComponent<PlayerInfoSheet>().LoadMoonMan = false;
////            if (InfoSheet.GetComponent<PlayerInfoSheet>().Controller4 == true)
////            {
////                InfoSheet.GetComponent<PlayerInfoSheet>().Controller4 = false;
////            }
////            else if (InfoSheet.GetComponent<PlayerInfoSheet>().Controller3 == true)
////            {
////                InfoSheet.GetComponent<PlayerInfoSheet>().Controller3 = false;
////            }
////            else if (InfoSheet.GetComponent<PlayerInfoSheet>().Controller2 == true)
////            {
////                InfoSheet.GetComponent<PlayerInfoSheet>().Controller2 = false;
////            }
////            else if (InfoSheet.GetComponent<PlayerInfoSheet>().Controller1 == true)
////            {
////                InfoSheet.GetComponent<PlayerInfoSheet>().Controller1 = false;
////            }
////            MMNotSelected = false;
////        }
////        if (PlayerName == "Foxy" && FNotSelected == true)
////        {
////            Debug.Log("Foxy UnSelected");
////            LvlSelc.GetComponent<LevelSelect>().ToLevelSelect(-1);
////            btns[currentNum].GetComponent<Image>().color = Color.white;

////            InfoSheet.GetComponent<PlayerInfoSheet>().LoadFoxy = false;
////            if (InfoSheet.GetComponent<PlayerInfoSheet>().Controller4 == true)
////            {
////                InfoSheet.GetComponent<PlayerInfoSheet>().Controller4 = false;
////            }
////            else if (InfoSheet.GetComponent<PlayerInfoSheet>().Controller3 == true)
////            {
////                InfoSheet.GetComponent<PlayerInfoSheet>().Controller3 = false;
////            }
////            else if (InfoSheet.GetComponent<PlayerInfoSheet>().Controller2 == true)
////            {
////                InfoSheet.GetComponent<PlayerInfoSheet>().Controller2 = false;
////            }
////            else if (InfoSheet.GetComponent<PlayerInfoSheet>().Controller1 == true)
////            {
////                InfoSheet.GetComponent<PlayerInfoSheet>().Controller1 = false;
////            }
////            FNotSelected = false;

////        }
////        if (PlayerName == "Pen" && PenNotSelected == true)
////        {
////            Debug.Log("Pen UnSelected");
////            LvlSelc.GetComponent<LevelSelect>().ToLevelSelect(-1);
////            btns[currentNum].GetComponent<Image>().color = Color.white;

////            InfoSheet.GetComponent<PlayerInfoSheet>().LoadPenguin = false;
////            if (InfoSheet.GetComponent<PlayerInfoSheet>().Controller4 == true)
////            {
////                InfoSheet.GetComponent<PlayerInfoSheet>().Controller4 = false;
////            }
////            else if (InfoSheet.GetComponent<PlayerInfoSheet>().Controller3 == true)
////            {
////                InfoSheet.GetComponent<PlayerInfoSheet>().Controller3 = false;
////            }
////            else if (InfoSheet.GetComponent<PlayerInfoSheet>().Controller2 == true)
////            {
////                InfoSheet.GetComponent<PlayerInfoSheet>().Controller2 = false;
////            }
////            else if (InfoSheet.GetComponent<PlayerInfoSheet>().Controller1 == true)
////            {
////                InfoSheet.GetComponent<PlayerInfoSheet>().Controller1 = false;
////            }
////            PenNotSelected = false;

////        }
////        if (PlayerName == "Butt" && ButtNotSelected == true)
////        {
////            Debug.Log("Buttlady UnSelected");
////            LvlSelc.GetComponent<LevelSelect>().ToLevelSelect(-1);
////            btns[currentNum].GetComponent<Image>().color = Color.white;

////            InfoSheet.GetComponent<PlayerInfoSheet>().LoadButtLady = false;
////            if (InfoSheet.GetComponent<PlayerInfoSheet>().Controller4 == true)
////            {
////                InfoSheet.GetComponent<PlayerInfoSheet>().Controller4 = false;
////            }
////            else if (InfoSheet.GetComponent<PlayerInfoSheet>().Controller3 == true)
////            {
////                InfoSheet.GetComponent<PlayerInfoSheet>().Controller3 = false;
////            }
////            else if (InfoSheet.GetComponent<PlayerInfoSheet>().Controller2 == true)
////            {
////                InfoSheet.GetComponent<PlayerInfoSheet>().Controller2 = false;
////            }
////            else if (InfoSheet.GetComponent<PlayerInfoSheet>().Controller1 == true)
////            {
////                InfoSheet.GetComponent<PlayerInfoSheet>().Controller1 = false;
////            }
////            ButtNotSelected = false;

////        }
////    }

//////------------------------------------ADD PLAYER-------------------------------------
////    public void AddPlayer(string PlayerName,Button currentBtn)
////    {

////        if (PlayerName == "MM" && MMNotSelected == false)
////        {
////            LvlSelc.GetComponent<LevelSelect>().ToLevelSelect(1);
////            //btns[currentNum].GetComponent<Image>().color = Color.gray;
////            Debug.Log("MoonMan Selected");
           
////            InfoSheet.GetComponent<PlayerInfoSheet>().LoadMoonMan = true;
////            //InfoSheet.GetComponent<PlayerInfoSheet>().Controller1 = true;
////            if (InfoSheet.GetComponent<PlayerInfoSheet>().Controller1 == false)
////            {
////                InfoSheet.GetComponent<PlayerInfoSheet>().Controller1 = true;
////                currentBtn.GetComponent<Image>().color = Color.red;
////            }
////            else if (InfoSheet.GetComponent<PlayerInfoSheet>().Controller2 == false)
////            {
////                InfoSheet.GetComponent<PlayerInfoSheet>().Controller2 = true;
////                currentBtn.GetComponent<Image>().color = Color.blue;
////            }
////            else if (InfoSheet.GetComponent<PlayerInfoSheet>().Controller3 == false)
////            {
////                InfoSheet.GetComponent<PlayerInfoSheet>().Controller3 = true;
////                currentBtn.GetComponent<Image>().color = Color.green;
////            }
////            else if (InfoSheet.GetComponent<PlayerInfoSheet>().Controller4 == false)
////            {
////                InfoSheet.GetComponent<PlayerInfoSheet>().Controller4 = true;
////                currentBtn.GetComponent<Image>().color = Color.gray;
////            }
           
////            MMNotSelected = true;
////        }
////        else if(PlayerName == "MM" && MMNotSelected == true)
////        {
////            Debug.Log("MoonMan already Selected");
////        }
////        ///--------------------------------------------------------

////        if (PlayerName == "Foxy" && FNotSelected == false)
////        {
////            Debug.Log("Foxy Selected");
////            LvlSelc.GetComponent<LevelSelect>().ToLevelSelect(1);
////            //btns[currentNum].GetComponent<Image>().color = Color.gray;

////            InfoSheet.GetComponent<PlayerInfoSheet>().LoadFoxy = true;
////            if (InfoSheet.GetComponent<PlayerInfoSheet>().Controller1 == false)
////            {
////                InfoSheet.GetComponent<PlayerInfoSheet>().Controller1 = true;
////                currentBtn.GetComponent<Image>().color = Color.red;
////            }
////            else if (InfoSheet.GetComponent<PlayerInfoSheet>().Controller2 == false)
////            {
////                InfoSheet.GetComponent<PlayerInfoSheet>().Controller2 = true;
////                currentBtn.GetComponent<Image>().color = Color.blue;
////            }
////            else if (InfoSheet.GetComponent<PlayerInfoSheet>().Controller3 == false)
////            {
////                InfoSheet.GetComponent<PlayerInfoSheet>().Controller3 = true;
////                currentBtn.GetComponent<Image>().color = Color.green;
////            }
////            else if (InfoSheet.GetComponent<PlayerInfoSheet>().Controller4 == false)
////            {
////                InfoSheet.GetComponent<PlayerInfoSheet>().Controller4 = true;
////                currentBtn.GetComponent<Image>().color = Color.gray;
////            }
////            FNotSelected = true;
////        }
////        else if (PlayerName == "Foxy" && FNotSelected == true)
////        {
////            Debug.Log("Foxy already Selected");
////        }
////        //-----------------------------------------------------------

////        if (PlayerName == "Pen" && PenNotSelected == false)
////        {
////            Debug.Log("Pen Selected");
////            LvlSelc.GetComponent<LevelSelect>().ToLevelSelect(1);
////            //btns[currentNum].GetComponent<Image>().color = Color.gray;

////            InfoSheet.GetComponent<PlayerInfoSheet>().LoadPenguin = true;
////            if (InfoSheet.GetComponent<PlayerInfoSheet>().Controller1 == false)
////            {
////                InfoSheet.GetComponent<PlayerInfoSheet>().Controller1 = true;
////                currentBtn.GetComponent<Image>().color = Color.red;
////            }
////            else if (InfoSheet.GetComponent<PlayerInfoSheet>().Controller2 == false)
////            {
////                InfoSheet.GetComponent<PlayerInfoSheet>().Controller2 = true;
////                currentBtn.GetComponent<Image>().color = Color.blue;
////            }
////            else if (InfoSheet.GetComponent<PlayerInfoSheet>().Controller3 == false)
////            {
////                InfoSheet.GetComponent<PlayerInfoSheet>().Controller3 = true;
////                currentBtn.GetComponent<Image>().color = Color.green;
////            }
////            else if (InfoSheet.GetComponent<PlayerInfoSheet>().Controller4 == false)
////            {
////                InfoSheet.GetComponent<PlayerInfoSheet>().Controller4 = true;
////                currentBtn.GetComponent<Image>().color = Color.gray;
////            }
////            PenNotSelected = true;

////        }
////        else if (PlayerName == "Pen" && PenNotSelected == true)
////        {
////            Debug.Log("Penguin already Selected");
////        }
////        //-----------------------------------------------------------

////        if (PlayerName == "Butt" && ButtNotSelected == false)
////        {
////            Debug.Log("Buttlady Selected");
////            LvlSelc.GetComponent<LevelSelect>().ToLevelSelect(1);
////           // btns[currentNum].GetComponent<Image>().color = Color.gray;

////            InfoSheet.GetComponent<PlayerInfoSheet>().LoadButtLady = true;
////            if (InfoSheet.GetComponent<PlayerInfoSheet>().Controller1 == false)
////            {
////                InfoSheet.GetComponent<PlayerInfoSheet>().Controller1 = true;
////            }
////            else if (InfoSheet.GetComponent<PlayerInfoSheet>().Controller2 == false)
////            {
////                InfoSheet.GetComponent<PlayerInfoSheet>().Controller2 = true;   
////            }
////            else if (InfoSheet.GetComponent<PlayerInfoSheet>().Controller3 == false)
////            {
////                InfoSheet.GetComponent<PlayerInfoSheet>().Controller3 = true;   
////            }
////            else if (InfoSheet.GetComponent<PlayerInfoSheet>().Controller4 == false)
////            {
////                InfoSheet.GetComponent<PlayerInfoSheet>().Controller4 = true; 
////            }
////            ButtNotSelected = true;
////        }
////        else if (PlayerName == "Butt" && ButtNotSelected == true)
////        {
////            Debug.Log("Butt already Selected");
////        }
       
////    }

//    public void AllowMovement()
//    {
//        //Added and remove functions-----------------------------------------------------
//        if (Input.GetButtonDown(PlayerSelect))//Player Selected
//        {
//            SelectSound.Play();
//            string P_name = btns[currentNum].name;
//            Debug.Log("Player1 Picked " + P_name);
//            //AddPlayer(P_name, btns[currentNum]);
//            if (P_name == "StaticButton")
//            {
//                // btns[currentNum].GetComponent<Image>().color = Color.gray;
//                //gameObject.GetComponent<NextLevel>().SelectLevel(2);
//            }
//        }

//        if (Input.GetButtonDown(PlayerRemove))
//        {
//            RemoveSound.Play();
//            string P_name = btns[currentNum].name;
//            Debug.Log("Player1 UnPicked " + P_name);
//            //RemovePlayer(P_name);
//        }

//        //Horizontal Movement functions---------------------------------------------------
//        if (Input.GetAxis(PlayerHor) == 0)
//        {
//            Nextbutton = true;
//            btns[currentNum].spriteState = HighlightedSprt;
//            btns[currentNum].Select();


//        }

//        if (Input.GetAxis(PlayerHor) > 0.2 && Nextbutton == true)
//        {
//            Nextbutton = false;
//            currentNum += 1;
//            if (currentNum >= btns.Count)
//            {
//                currentNum = 0;

//            }
//            else if (currentNum < 0)
//            {
//                currentNum = btns.Count - 1;

//            }

//            btns[currentNum].Select();
//            Movesound.pitch += .2f;
//            Movesound.Play();

//        }

//        else if (Input.GetAxis(PlayerHor) < -0.2 && Nextbutton == true)
//        {
//            Nextbutton = false;
//            currentNum -= 1;
//            if (currentNum >= btns.Count)
//            {
//                currentNum = 0;


//            }
//            else if (currentNum < 0)
//            {
//                currentNum = btns.Count - 1;

//            }

//            btns[currentNum].Select();

//            Movesound.pitch -= .2f;
//            Movesound.Play();
//        }

//        if (Movesound.pitch <= .8f)
//        {
//            Movesound.pitch = 1.8f;
//        }

//        if (Movesound.pitch > 1.8f)
//        {
//            Movesound.pitch = 1f;
//        }

//        btns[0].Select();
//        btns[1].Select();
//    }
   
//    public void Update()
//    {
//        AllowMovement();
//    }
   
//}
