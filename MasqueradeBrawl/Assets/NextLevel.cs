using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class NextLevel : MonoBehaviour {

    public void SelectLevel(int indexNum)
    {
        if (Input.GetButtonDown("Submit"))
        {

            if (gameObject.GetComponent<Image>().color == Color.white)//Selected
            {
                gameObject.GetComponent<Image>().color = Color.grey;
                StartCoroutine(LoadLevel(indexNum));
            }
            else if (gameObject.GetComponent<Image>().color == Color.grey)
            {
                gameObject.GetComponent<Image>().color = Color.white;

            }

        }
        else if (Input.GetButtonDown("Submit2"))
        {
            if (gameObject.GetComponent<Image>().color == Color.white)//Selected
            {
                gameObject.GetComponent<Image>().color = Color.grey;
                StartCoroutine(LoadLevel(indexNum));
            }
            else if (gameObject.GetComponent<Image>().color == Color.grey)
            {
                gameObject.GetComponent<Image>().color = Color.white;

            }
        }
        else if (Input.GetButtonDown("Submit3"))
        {
            if (gameObject.GetComponent<Image>().color == Color.white)//Selected
            {
                gameObject.GetComponent<Image>().color = Color.grey;
                StartCoroutine(LoadLevel(indexNum));
            }
            else if (gameObject.GetComponent<Image>().color == Color.grey)
            {
                gameObject.GetComponent<Image>().color = Color.white;

            }
        }
        else if (Input.GetButtonDown("Submit4"))
        {
            if (gameObject.GetComponent<Image>().color == Color.white)//Selected
            {
                gameObject.GetComponent<Image>().color = Color.grey;
                StartCoroutine(LoadLevel(indexNum));
            }
            else if (gameObject.GetComponent<Image>().color == Color.grey)
            {
                gameObject.GetComponent<Image>().color = Color.white;

            }
        }
    }

    public IEnumerator LoadLevel(int indexNum)
    {
        Debug.Log("Loading Level");
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(indexNum);
    }
}
