using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefScript : MonoBehaviour {

	public void Start()
    {
        GameObject.Find("PlayerInfo").GetComponent<PlayerInfoSheet>().ActivePlayers();
    }

   
}
