using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinnerScript : MonoBehaviour {

    public Image P1_win, P2_win, P3_win, P4_win;
    public List<GameObject> PlayersAlive;
    public List<string> PlayerList;
    public GameObject MainCam;
    public int totalPlayersAlive = 4;
    public int KillChecker = 0;

	// Use this for initialization
	void Start () {
        P1_win.enabled = false;
        P2_win.enabled = false;
        P3_win.enabled = false;
        P4_win.enabled = false;
        //PlayerList is made from PlayerInfoSheet.cs  
        for (int i = 0; i < PlayerList.Count; i++)
        {
            if (GameObject.Find(PlayerList[i]) == true)
            {
                PlayersAlive.Add(GameObject.Find(PlayerList[i]));
            }
        }
        
        MainCam.GetComponent<CameraMovement>().Players = PlayersAlive;

	}

    public IEnumerator RestartScene()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("_CharSelect", LoadSceneMode.Single);
    }
    
    public void WinChecker()
    {
       
        for (int i = 0; i < PlayersAlive.Count; i++)
        {
            if (PlayersAlive[i].GetComponent<PlayerHealth>().PlayerDead == true)
            {
                MainCam.GetComponent<CameraMovement>().DeleteUpdate(PlayersAlive[i].name);
                PlayersAlive.RemoveAt(i);
                

            }
        }
        if (PlayersAlive.Count < 2)
        {
            Debug.Log(PlayersAlive[0].name);
            if (PlayersAlive[0].name == "_Penguin(Clone)")
            {
                P1_win.enabled = true;
                StartCoroutine(RestartScene());
            }
            if (PlayersAlive[0].name == "_ButtLady(Clone)")
            {
                P2_win.enabled = true;
                StartCoroutine(RestartScene());
            }
            if (PlayersAlive[0].name == "_Foxy(Clone)")
            {
                P3_win.enabled = true;
                StartCoroutine(RestartScene());
            }
            if (PlayersAlive[0].name == "_MoonMan(Clone)")
            {
                P4_win.enabled = true;
                StartCoroutine(RestartScene());
            }
           
        }

    }
}
