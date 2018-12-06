using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class NextLevel : MonoBehaviour {

    public bool CanSelectLevel = false;
    public List<GameObject> Levels;
    public bool Nextbutton;
    public string LastPickerA;
    public GameObject Lamp1;
    public GameObject Lamp2;
    public string LastPickerHor;
    int currentNum = 0;
   
    public void Start()
    {
        Lamp1.GetComponent<SpriteRenderer>().color = Color.gray;
        Lamp2.GetComponent<SpriteRenderer>().color = Color.gray;
        for (int i = 1; i < Levels.Count; i++)
        {
            Levels[i].SetActive(false);
        }
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
            if (Input.GetButtonDown(LastPickerA))//Player Selected
            {
                if (Levels[currentNum].name == "StaticButtonActive")
                {
                    Debug.Log("Load Static Level");
                    StartCoroutine(LoadLevel(2));
                }
                else if (Levels[currentNum].name == "FallingButtonActive")
                {
                    Debug.Log("Load Falling Level");
                    StartCoroutine(LoadLevel(3));
                }
            }

            if (Input.GetAxis(LastPickerHor) == 0)
            {
                Nextbutton = true;
            }

            if (Input.GetAxis(LastPickerHor) > 0.2 && Nextbutton == true)
            {
                Nextbutton = false;
                currentNum += 1;
              
                //---------------------------------------------
                if (currentNum >= Levels.Count)
                {
                    currentNum = 0;//change to 1? try to skip unselected screen.
                }
                else if (currentNum < 0)
                {
                    currentNum = Levels.Count;
                }

                for (int x = 0; x < currentNum; x++)
                {
                    Levels[x].SetActive(false);
                }
                Levels[currentNum].SetActive(true);
                for (int x = currentNum + 1; x <= Levels.Count - 1; x++)
                {
                    Levels[x].SetActive(false);
                }
                //Movesound.pitch += .2f;
                //Movesound.Play();

            }

        }
           
    }
    public IEnumerator LoadLevel(int indexNum)
    {
        Debug.Log("Loading Level");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(indexNum);
    }
}
