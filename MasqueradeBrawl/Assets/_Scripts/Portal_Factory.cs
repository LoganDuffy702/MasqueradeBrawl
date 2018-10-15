using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal_Factory : MonoBehaviour {

    public GameObject Portals;
    public bool ReleaseUp;
    public bool ReleaseRight;
    public bool ReleaseLeft;
    public float ExitSpeed;
    public float delay;
    //private List<Transform> Ptrans = new List<Transform>();
    private Vector3 EndPoint; 
	void Start () {
        //for (int i = 0; i < Players.Count; i++)
        //{
        //    Ptrans[i] = Players[i].GetComponent<Transform>();
        //}
        EndPoint = Portals.transform.Find("Portal_End").transform.position;

       
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player1") || other.gameObject.CompareTag("Player2"))
        {
            if (ReleaseUp == true)
            {                
                other.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 2);
                other.gameObject.transform.position = EndPoint;
            }
            else if (ReleaseRight == true)
            {                
                other.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * ExitSpeed);
                other.gameObject.transform.position = EndPoint;
            }
            else if (ReleaseLeft == true)
            {                
                other.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.left * ExitSpeed);
                other.gameObject.transform.position = EndPoint;
            }
            else
            {
                other.gameObject.transform.position = EndPoint;
            }

        }
    }
}
