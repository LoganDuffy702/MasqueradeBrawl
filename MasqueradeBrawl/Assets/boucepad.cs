using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boucepad : MonoBehaviour {

    public GameObject Particals;

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Penguin") || other.gameObject.CompareTag("MoonMan") ||
            other.gameObject.CompareTag("ButtLady") || other.gameObject.CompareTag("Foxy"))
        {
            var PP = Instantiate(Particals);
            PP.transform.position = other.transform.position;
            PP.GetComponent<ParticleSystem>().Play();
            Destroy(PP, 1f);
        }
    }
}
