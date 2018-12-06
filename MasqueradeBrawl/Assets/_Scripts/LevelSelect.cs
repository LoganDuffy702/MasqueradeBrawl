using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class LevelSelect : MonoBehaviour {

    public int count = 0;
    GameObject StaticLevel, FallingLevel;
    int add = 0;
    public GameObject Lamp1, Lamp2;
    public GameObject CharacterCanvas;
    public void Start()
    {
        //MM = GameObject.Find("MM");
        //Foxy = GameObject.Find("Foxy");
        //Pen = GameObject.Find("Pen");
        //Butt = GameObject.Find("Butt");

        StaticLevel = GameObject.Find("StaticButton");
        //StaticLevel.GetComponent<Button>().interactable = false;
        StaticLevel.GetComponent<Image>().color = Color.gray;

        FallingLevel = GameObject.Find("FallingButton");
        //FallingLevel.GetComponent<Button>().interactable = false;
        FallingLevel.GetComponent<Image>().color = Color.gray;

        Lamp1.GetComponent<SpriteRenderer>().color = Color.gray;
        Lamp2.GetComponent<SpriteRenderer>().color = Color.gray;

    }
    public void ToLevelSelect(int P_selected)
    {
        count = count + P_selected;
        if (count > 1 && add == 0)
        {

            StaticLevel.GetComponent<Button>().interactable = true;
            StaticLevel.GetComponent<Image>().color = Color.white;
            FallingLevel.GetComponent<Button>().interactable = true;
            FallingLevel.GetComponent<Image>().color = Color.white;
           
            //CharacterCanvas.GetComponent<MainMenuScript>().btns.Add(StaticLevel.GetComponent<Button>());
           // CharacterCanvas.GetComponent<MainMenuScript>().btns.Add(FallingLevel.GetComponent<Button>());
            Lamp1.GetComponent<SpriteRenderer>().color = Color.white;
            Lamp2.GetComponent<SpriteRenderer>().color = Color.white;
            add = 1;
           

        }
        else if (count < 2)
        {
            StaticLevel.GetComponent<Button>().interactable = false;
            StaticLevel.GetComponent<Image>().color = Color.gray;
            FallingLevel.GetComponent<Button>().interactable = false;
            FallingLevel.GetComponent<Image>().color = Color.gray;
            add = 0;
            //CharacterCanvas.GetComponent<MainMenuScript>().btns.RemoveAt(4);
            //CharacterCanvas.GetComponent<MainMenuScript>().btns.Remove(StaticLevel.GetComponent<Button>());
          //  CharacterCanvas.GetComponent<MainMenuScript>().btns.Remove(FallingLevel.GetComponent<Button>());
            // CharacterCanvas.GetComponent<MainMenuScript>().btns.RemoveAt(5);
            Lamp1.GetComponent<SpriteRenderer>().color = Color.gray;
            Lamp2.GetComponent<SpriteRenderer>().color = Color.gray;

        }
    }
   
}
