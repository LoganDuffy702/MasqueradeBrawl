using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class LevelSelect : MonoBehaviour {

    public int count = 0;
    GameObject StaticLevel, FallingLevel;
    public GameObject Lamp1, Lamp2;
    public void Start()
    {
        //MM = GameObject.Find("MM");
        //Foxy = GameObject.Find("Foxy");
        //Pen = GameObject.Find("Pen");
        //Butt = GameObject.Find("Butt");

        StaticLevel = GameObject.Find("StaticButton");
        StaticLevel.GetComponent<Button>().interactable = false;
        StaticLevel.GetComponent<Image>().color = Color.gray;

        FallingLevel = GameObject.Find("FallingButton");
        FallingLevel.GetComponent<Button>().interactable = false;
        FallingLevel.GetComponent<Image>().color = Color.gray;

        Lamp1.GetComponent<SpriteRenderer>().color = Color.gray;
        Lamp2.GetComponent<SpriteRenderer>().color = Color.gray;

    }
    public void ToLevelSelect(int P_selected)
    {
        count = count + P_selected;
        if (count > 1)
        {

            StaticLevel.GetComponent<Button>().interactable = true;
            StaticLevel.GetComponent<Image>().color = Color.white;
            FallingLevel.GetComponent<Button>().interactable = true;
            FallingLevel.GetComponent<Image>().color = Color.white;
            Lamp1.GetComponent<SpriteRenderer>().color = Color.white;
            Lamp2.GetComponent<SpriteRenderer>().color = Color.white;

            //MM.GetComponent<Button>().interactable = false;
            //Foxy.GetComponent<Button>().interactable = false;
            //Pen.GetComponent<Button>().interactable = false;
            //Butt.GetComponent<Button>().interactable = false;

        }
        else 
        {
            StaticLevel.GetComponent<Button>().interactable = false;
            StaticLevel.GetComponent<Image>().color = Color.gray;
            FallingLevel.GetComponent<Button>().interactable = false;
            FallingLevel.GetComponent<Image>().color = Color.gray;
            Lamp1.GetComponent<SpriteRenderer>().color = Color.gray;
            Lamp2.GetComponent<SpriteRenderer>().color = Color.gray;

            //MM.GetComponent<Button>().interactable = true;
            //Foxy.GetComponent<Button>().interactable = true;
            //Pen.GetComponent<Button>().interactable = true;
            //Butt.GetComponent<Button>().interactable = true;
        }
    }
   
}
