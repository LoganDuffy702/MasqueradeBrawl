using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal_Factory : MonoBehaviour {

    public GameObject Portals;
    //private List<Transform> Ptrans = new List<Transform>();
    private Vector3 EndPoint; 
	void Start () {
        //for (int i = 0; i < Players.Count; i++)
        //{
        //    Ptrans[i] = Players[i].GetComponent<Transform>();
        //}
        EndPoint = Portals.transform.Find("Portal_End").transform.position;

       
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Players"))
        {
            other.gameObject.transform.position = EndPoint;
        }
    }
}
