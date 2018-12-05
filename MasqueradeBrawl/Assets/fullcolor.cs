using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class fullcolor : MonoBehaviour {

	// Use this for initialization
	void Update () {
        gameObject.GetComponent<Image>().color = Color.white;
	}
	
}
