using UnityEngine;
using System.Collections;

public class CamPowerUp : MonoBehaviour {

    public Camera Camera1;
    public bool flipMe;
    public float duration;
    // Use this for initialization

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

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Players"))
        {
            
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            flipMe = true;
           
        }

    }

}
