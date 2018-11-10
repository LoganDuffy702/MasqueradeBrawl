using UnityEngine;
using System.Collections;

public class AttackDestroy : MonoBehaviour {

	public float DestroySpeed;
    public bool cloud = false;
	// Update is called once per frame
	void Update () {
        if (cloud == true)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = (Vector2.left * 15f);
            Destroy(this.gameObject, DestroySpeed);
        }
        else
        {
            Destroy(this.gameObject, DestroySpeed);
        }
		
	}
}
