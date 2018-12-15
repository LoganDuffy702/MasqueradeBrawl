using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MatchTimer : MonoBehaviour {

    // Use this for initialization
    public float TimeLeft;
    public Text TimeText;
    public Image Draw;
    private void Start()
    {
        Draw.enabled = false;
    }
    // Update is called once per frame
    void Update () {
        if (TimeLeft > 0)
        {
            countdown();
           
        }
        else if (TimeLeft <= 0)
        {
            TimeLeft = 0;
            Draw.enabled = true;
            StartCoroutine(BackToSelect());
            
        }
 
        TimeText.text = Mathf.RoundToInt(TimeLeft).ToString();
	}
    public void countdown()
    {
        TimeLeft -= Time.deltaTime;
    }

    public IEnumerator BackToSelect()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(1);
    }
}
