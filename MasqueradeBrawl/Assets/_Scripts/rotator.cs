using UnityEngine;
using System.Collections;

public class rotator : MonoBehaviour {

	public int XRotationSpeed = 0; 
	public int YRotationSpeed = 0;
	public int ZRotationSpeed = 0;
	public float RotationTimer = 1.0f;
    
	public bool touched = false;

	// Update is called once per frame
	void Update () {
		if (touched == false) {
			transform.Rotate (new Vector3 (0+XRotationSpeed,0+YRotationSpeed, 0+ZRotationSpeed));
		}
		else if (touched == true && RotationTimer >= 0.0f) {
			transform.Rotate (new Vector3 (XRotationSpeed * 2, YRotationSpeed*2 , ZRotationSpeed*2));
			RotationTimer -= Time.deltaTime;
		}
		if (RotationTimer <= 0.0f) {
			touched = false;
			RotationTimer = 1.0f;
		}
	}
		
}
