using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinnerScript : MonoBehaviour {

    public Image WinnerTag;
    public List<GameObject> PlayersAlive;
    public List<string> PlayerList;
    public GameObject MainCam;
    //public Player Infosheet;
    public int totalPlayersAlive = 4;
    public bool UseSpecialCam = true;
    public int KillChecker = 0;

	// Use this for initialization
	void Start () {
        WinnerTag.enabled = false;
       
       
        //PlayerList is made from PlayerInfoSheet.cs  
        for (int i = 0; i < PlayerList.Count; i++)
        {
            if (GameObject.Find(PlayerList[i]) == true)
            {
                PlayersAlive.Add(GameObject.Find(PlayerList[i]));
                if (UseSpecialCam == true)
                {
                    MainCam.SetActive(true);
                }
                else
                {
                    MainCam.GetComponent<CameraMovement>().Players = PlayersAlive;
                }
            }
        }
	}

    public IEnumerator RestartScene()
    {
        
        GameObject.Find("PlayerInfo").GetComponent<PlayerInfoSheet>().Killold();
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("_CharSelect", LoadSceneMode.Single);
    }
    
    public void WinChecker()
    {
       
        for (int i = 0; i < PlayersAlive.Count; i++)
        {
            if (PlayersAlive[i].GetComponent<PlayerHealth>().PlayerDead == true)
            {
                if (UseSpecialCam == true)
                {
                    MainCam.SetActive(true);
                }
                else
                {
                    MainCam.GetComponent<CameraMovement>().DeleteUpdate(PlayersAlive[i].name);
                }
                

                PlayersAlive.RemoveAt(i);

            }
        }
        if (PlayersAlive.Count < 2)
        {
            if (UseSpecialCam == true)
            {
                MainCam.SetActive(true);
            }
            else
            {
                MainCam.GetComponent<CameraMovement>().Showwinner = true;
            }
            WinnerTag.enabled = true;
            //WinnerTag.GetComponent<Text>().enabled = false;
            StartCoroutine(RestartScene());
            

        }

    }
}
