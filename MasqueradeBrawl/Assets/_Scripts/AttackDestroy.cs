using UnityEngine;
using System.Collections;

public class AttackDestroy : MonoBehaviour {

	public float DestroySpeed;

	// Update is called once per frame
	void Update () {
		Destroy (this.gameObject, DestroySpeed);
	}
}
