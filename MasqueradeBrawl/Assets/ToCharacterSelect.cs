using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ToCharacterSelect : MonoBehaviour {

	
	
	// Update is called once per frame
	public void GoToChar () {
        SceneManager.LoadScene("_CharSelect", LoadSceneMode.Single);
    }
    public void QuitGame()
    {
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
