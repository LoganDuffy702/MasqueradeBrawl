using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class NextLevel : MonoBehaviour {

    public bool CanSelectLevel = false;
    public List<GameObject> Levels;
   
    public GameObject ControllsScreen;
    public Image Tint;
   
    
    public string LastPickerHor;
    
   
    public void Start()
    {
        Tint.enabled = true;
        Levels[0].SetActive(true);
        Levels[1].SetActive(true);

        ControllsScreen.GetComponent<SpriteRenderer>().enabled = false;
    }

    public void ActivateLevel()
    {
        CanSelectLevel = true;
        Tint.enabled = false;
    }
    
    public void DeActive()
    {
        Tint.enabled = true;
        Levels[0].GetComponent<Image>().color = Color.gray;
        Levels[1].GetComponent<Image>().color = Color.gray;
        CanSelectLevel = false;
    }

    public void Update()
    {
        if (CanSelectLevel == true)
        {

            if (Input.GetButtonDown("Player1_Start") ||Input.GetButtonDown("Player2_Start") ||
                Input.GetButtonDown("Player3_Start") || Input.GetButtonDown("Player4_Start"))
            {
                Levels[0].SetActive(false);
                StartCoroutine(LoadLevel(2));
            }
            else if (Input.GetButtonDown("Player1_Back") || Input.GetButtonDown("Player2_Back") ||
                Input.GetButtonDown("Player3_Back") || Input.GetButtonDown("Player4_Back"))
            {
                Levels[1].SetActive(false);
                StartCoroutine(LoadLevel(3));
            }
        } 
    }
    public IEnumerator LoadLevel(int indexNum)
    {
        
        yield return new WaitForSeconds(2f);
        ControllsScreen.GetComponent<SpriteRenderer>().enabled = true;
        yield return new WaitForSeconds(7f);
        SceneManager.LoadScene(indexNum);
    }
}
