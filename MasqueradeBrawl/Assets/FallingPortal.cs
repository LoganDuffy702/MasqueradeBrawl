using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPortal : MonoBehaviour {

    public List<GameObject> exitList = new List<GameObject>();
    public AudioSource Exitsound;
    public float exitforce;
    bool goleft, goright;
    // Use this for initialization

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Penguin") || other.gameObject.CompareTag("MoonMan") ||
            other.gameObject.CompareTag("ButtLady") || other.gameObject.CompareTag("Foxy"))
        {
            //int r = Mathf.Abs(Random.Range(0, exitList.Count+1));
            other.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            Exitsound.Play();
            if (goleft == true)
            {
                other.gameObject.transform.position = exitList[1].transform.position;
                other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * exitforce);
                goright = true;
                goleft = false;
            }
            else if (goright == true)
            {
                other.gameObject.transform.position = exitList[0].transform.position;
                other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * exitforce);
                goright = false;
                goleft = true;
            }
            else
            {
                other.gameObject.transform.position = exitList[1].transform.position;
                other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * exitforce);
                goright = true;
                goleft = false;
            }
            //other.gameObject.transform.position = exitList[r].transform.position;
            //other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.left * 2);
           
        }
    }
}
