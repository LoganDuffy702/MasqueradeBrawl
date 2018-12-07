using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class NextLevel : MonoBehaviour {

    public bool CanSelectLevel = false;
    public List<GameObject> Levels;
    public bool Fadein;
    public string LastPickerA;
    public GameObject Lamp1;
    public GameObject ControllsScreen;
    public GameObject Lamp2;
    
    public string LastPickerHor;
    
   
    public void Start()
    {
        Lamp1.GetComponent<SpriteRenderer>().color = Color.gray;
        Lamp2.GetComponent<SpriteRenderer>().color = Color.gray;
        Levels[0].SetActive(true);
        Levels[1].SetActive(true);
        Fadein = false;
    }

    public void ActivateLevel()
    {
        Lamp1.GetComponent<SpriteRenderer>().color = Color.white;
        Lamp2.GetComponent<SpriteRenderer>().color = Color.white;
        StartCoroutine(SendActivate());
    }
    public IEnumerator SendActivate()
    {
        yield return new WaitForSeconds(.25f);
        CanSelectLevel = true;

    }
    public void DeActive()
    {
        Lamp1.GetComponent<SpriteRenderer>().color = Color.gray;
        Lamp2.GetComponent<SpriteRenderer>().color = Color.gray;
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
            else if (Input.GetButtonDown("Player1_Back") || Input.GetButtonDown("Player2_Back") || Input.GetButtonDown("Player3_Back") || Input.GetButtonDown("Player4_Back"))
            {
                Levels[1].SetActive(false);
                StartCoroutine(LoadLevel(3));
            }
        }

        if (Fadein == true)
        {

            ControllsScreen.GetComponent<SpriteRenderer>().color = new Color(255,255,255, 1);
        }
        else if (Fadein == false)
        {
            ControllsScreen.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255,0);
        }
           
    }
    public IEnumerator LoadLevel(int indexNum)
    {
        //Debug.Log("Loading Level");
        yield return new WaitForSeconds(2f);
        Fadein = true;
        yield return new WaitForSeconds(7f);
        Fadein = false;
        SceneManager.LoadScene(indexNum);
    }
}
