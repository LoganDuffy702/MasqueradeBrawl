using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class MainMenuScript : MonoBehaviour {

    //public List<Button> ButtonList = new List<Button>();
    //public int count = 0;
    //public bool canInteract = true;
    public void StartButton(int indexNum)
    {
        SceneManager.LoadScene(indexNum);
        
    }

    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
    
}
