using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class NextLevel : MonoBehaviour {

    public void SelectLevel(int indexNum)
    {
        StartCoroutine(LoadLevel(indexNum));
       // gameObject.GetComponent<Image>().color = Color.grey;

    }

    public IEnumerator LoadLevel(int indexNum)
    {
        Debug.Log("Loading Level");
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(indexNum);
    }
}
