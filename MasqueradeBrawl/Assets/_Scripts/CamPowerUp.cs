﻿using UnityEngine;
using System.Collections;

public class CamPowerUp : MonoBehaviour {

    private Camera Camera1;
    public bool flipMe;
    public float duration;
    public float LifeSpan;
    // Use this for initialization

    void Start()
    {
        Camera1 = GameObject.Find("Main Camera").GetComponent<Camera>();
        if (Camera1 == null)
        {
            Debug.Log("NO Camera FOund");
        }
        StartCoroutine(HidMe());
    }
    void Update()
    {
        if (flipMe == true)
        {
            CamFlip();
            StartCoroutine(FlipTimer());
        }
    }

    void CamFlip()
    {
        Camera1.gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 180f);    
    }
    void CamFix()
    {
        Camera1.gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
    }
    public IEnumerator FlipTimer()
    {
        yield return new WaitForSeconds(duration);
        flipMe = false;
        CamFix();
        Destroy(gameObject);
    }

    public IEnumerator HidMe()
    {
        yield return new WaitForSeconds(LifeSpan);
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        Destroy(gameObject, duration + 10);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Players"))
        {
            
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            flipMe = true;
           
        }

    }

}
