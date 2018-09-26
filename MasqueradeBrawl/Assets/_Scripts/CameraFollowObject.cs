using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Causes the main camera to follow the attached gameobject at the given distance and angle
/// </summary>
[ExecuteInEditMode]
public class CameraFollowObject : MonoBehaviour {

    public Vector3 offset = Vector3.up + Vector3.back;
    
	void Update () {
        Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, transform.position + offset, 0.9f);
        Camera.main.transform.LookAt(transform);
	}
}
