using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {
    public AudioSource Doorsound;
    Animator anim;
    public void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        //anim = gameObject.GetComponent<Animator>();
        if (other.gameObject.CompareTag("Penguin") || other.gameObject.CompareTag("MoonMan") ||
            other.gameObject.CompareTag("ButtLady") || other.gameObject.CompareTag("Foxy"))
        {
            anim.SetBool("Open", true);
            Doorsound.Play();
        }
       
            

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Penguin") || other.gameObject.CompareTag("MoonMan") ||
           other.gameObject.CompareTag("ButtLady") || other.gameObject.CompareTag("Foxy"))
        {
            Doorsound.Play();
            anim.SetBool("Open", false);
        }
       
    }
}
