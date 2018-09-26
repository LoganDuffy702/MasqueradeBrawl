using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimTest : MonoBehaviour {

    // Use this for initialization
    public float rotationOffset = 0;
    public GameObject ParentPlayer;
   // private SpriteRenderer sr;
    
    // Update is called once per frame
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        Vector3 NewInput = new Vector3(Input.GetAxis("HorAim"), Input.GetAxis("VerAim"), 0f);
        
        if (NewInput.sqrMagnitude < 0.1f)
        {
            return;
        }

        NewInput.Normalize();
        float Heading = Vector3.Dot(Vector3.up, NewInput);
        Vector3 NewRotation = transform.rotation.eulerAngles;
        NewRotation.z = Heading * rotationOffset;
        
        if (NewInput.x >= 0)
        {
            NewRotation.y = 180f;
            ParentPlayer.GetComponent<SpriteRenderer>().flipX = true;


        }
        if (NewInput.x <= 0)
        {
            NewRotation.y = 0f;
            ParentPlayer.GetComponent<SpriteRenderer>().flipX = false;

        }

        transform.rotation = Quaternion.Euler(NewRotation);
    }
}
