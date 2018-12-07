using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class fullcolor : MonoBehaviour {

    public bool isGameObject,isImage;
	// Use this for initialization
	void Update () {
       
        if (isGameObject == true)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        }
        if (isImage == true)
        {
            gameObject.GetComponent<Image>().color = Color.white;
        }
	}
	
}
