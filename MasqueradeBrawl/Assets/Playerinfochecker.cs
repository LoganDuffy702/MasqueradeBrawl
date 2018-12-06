using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerinfochecker : MonoBehaviour {

    GameObject[] PlayerInfoList;
    public GameObject Info;
    private void Start()///YOu may have to put this in the playerinfo file 
    {
       
        PlayerInfoList = GameObject.FindGameObjectsWithTag("PlayerInfo");
        if (PlayerInfoList.Length > 1)
        {
            foreach (GameObject item in PlayerInfoList)
            {
                Destroy(item);
            }
            CreateNewInfoSheet();
        }
        
    }
    void CreateNewInfoSheet()
    {
        var newSheet = Instantiate(Info);
        newSheet.name = "PlayerInfo";
    }
    
}
