using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onscript : MonoBehaviour {

    private void Start()
    {
        gameObject.GetComponent<RigidWeapon>().enabled = true;

    }
    // Update is called once per frame
    void Update () {
        gameObject.GetComponent<RigidWeapon>().enabled = true;
	}
}
