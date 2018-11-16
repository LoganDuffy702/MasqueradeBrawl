using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinnerScript : MonoBehaviour {

    public Image P1_win, P2_win, P3_win, P4_win;
    public int WinNum = 0;

	// Use this for initialization
	void Start () {
        P1_win.enabled = false;
        P2_win.enabled = false;
        P3_win.enabled = false;
        P4_win.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (WinNum == 1)
        {
            P1_win.enabled = true;
            StartCoroutine(RestartScene());
        }
        else if (WinNum == 2)
        {

        }
        else if (WinNum == 3)
        {

        }
        else if (WinNum == 4)
        {

        }
        
       
	}

    public IEnumerator RestartScene()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("Static_Level", LoadSceneMode.Single);
    }
    
    public int ShowWinner()
    {
        
        int WinnerNumber = 0;
        return WinnerNumber;
    }
}
