using UnityEngine;
using System.Collections;

public class BulletContact : MonoBehaviour {


	public Transform OnContact;
    
    public string[] EnemyTags;
    // Update is called once per frame

    void OnCollisionEnter2D(Collision2D col){

        for (int i = 0; i < EnemyTags.Length; i++)
        {
            if (col.gameObject.tag.Equals(EnemyTags[i])){
			    //Destroy(col.gameObject);
			    Instantiate (OnContact, gameObject.transform.position,gameObject.transform.rotation);
			    Destroy (this.gameObject);
		    }
        }
		



	}
}
