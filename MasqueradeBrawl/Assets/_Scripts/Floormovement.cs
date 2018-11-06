using UnityEngine;
using System.Collections;

public class Floormovement : MonoBehaviour
{

    public int MoveSpeed;
    public float DestroyFade = 1;
    public bool TimedDeath;
    public GameObject OnContact;
    // Update is called once per frame
    void FixedUpdate()
    {

        //Vector2 mousePosition = new Vector2 (Camera.main.ScreenToWorldPoint (Input.mousePosition).x, Camera.main.ScreenToWorldPoint (Input.mousePosition).y); //Supposedly binds firepoint to screen/mouse aspect:ratio...
        transform.Translate(Vector3.up * Time.deltaTime * MoveSpeed);
        Destroy(this.gameObject, DestroyFade);
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.CompareTag("Walls"))
        {
            Instantiate(OnContact, transform.localPosition, transform.localRotation);
            Destroy(gameObject);
        }
        if (col.gameObject.CompareTag("Penguin") || col.gameObject.CompareTag("MoonMan") || col.gameObject.CompareTag("ButtLady"))
        {
            Instantiate(OnContact, transform.localPosition, transform.localRotation);
            Destroy(gameObject);
        }

    }
}

