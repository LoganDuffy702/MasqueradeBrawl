using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinnerScript : MonoBehaviour {

    public Image P1_win, P2_win, P3_win, P4_win;
    public List<GameObject> Players;
    public GameObject MainCam;
    public int totalPlayers = 4;
    public int KillChecker = 0;

	// Use this for initialization
	void Start () {
        P1_win.enabled = false;
        P2_win.enabled = false;
        P3_win.enabled = false;
        P4_win.enabled = false;
	}
	
	
    public IEnumerator RestartScene()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("Static_Level", LoadSceneMode.Single);
    }
    
    public void WinChecker()
    {
       
        for (int i = 0; i < Players.Count; i++)
        {
            if (Players[i].GetComponent<PlayerHealth>().PlayerDead == true)
            {
                MainCam.GetComponent<CameraMovement>().DeleteUpdate(Players[i].name);
                Players.RemoveAt(i);
                

            }
        }
        if (Players.Count < 2)
        {
            Debug.Log(Players[0].name);
            if (Players[0].name == "_Penguin")
            {
                P1_win.enabled = true;
                StartCoroutine(RestartScene());
            }
            if (Players[0].name == "_ButtLady")
            {
                P2_win.enabled = true;
                StartCoroutine(RestartScene());
            }
            if (Players[0].name == "_Foxy")
            {
                P3_win.enabled = true;
                StartCoroutine(RestartScene());
            }
            if (Players[0].name == "_MoonMan")
            {
                P4_win.enabled = true;
                StartCoroutine(RestartScene());
            }
           
        }

    }
}
