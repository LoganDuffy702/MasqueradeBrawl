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
    //private void Start()
    //{
    //    count = 0;
    //}
    //private void Update()
    //{
    //    int Next = (int)Input.GetAxis("Horizontal");
    //    if (Next != 0 && canInteract)
    //    {
    //        canInteract = false;
    //        StartCoroutine(NextChar(Next));
    //        ButtonList[count].GetComponent<Button>().Select();
            
    //    }
        
    //    if (Input.GetButtonDown("Submit"))
    //    {
    //        StartButton(1);
    //    }
    //    if (Input.GetButtonDown("Cancel"))
    //    {
    //        ExitGame();
    //    }
    //}
    
    //public IEnumerator NextChar(int input)
    //{

    //    if (input < 0 && count < ButtonList.Count-1)
    //    {
    //        count++;
    //    }
    //    else if (input > 0 && count > 0)
    //    {
    //        count--;
    //    }
    //    yield return new WaitForSeconds(1f);
    //    canInteract = true;

    //}

    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
    
}
