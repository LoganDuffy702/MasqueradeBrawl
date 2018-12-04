using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMovementRedux : MonoBehaviour
{

    public float MoveSpeed;
    public float DestroyFade = 1;
    public bool TimedDeath;
    //float tempMove;
    //ublic GameObject OnContact;
    // Update is called once per frame
    private void Start()
    {
        //tempMove = (Random.Range(5, 25));
    }
    void FixedUpdate()
    {

        //Vector2 mousePosition = new Vector2 (Camera.main.ScreenToWorldPoint (Input.mousePosition).x, Camera.main.ScreenToWorldPoint (Input.mousePosition).y); //Supposedly binds firepoint to screen/mouse aspect:ratio...
        transform.Translate( Vector3.up * Time.deltaTime * MoveSpeed);
        Destroy(gameObject, DestroyFade);
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.CompareTag("DeathWall"))
        {
           // Instantiate(OnContact, transform.localPosition, transform.localRotation);
            Destroy(gameObject);
        }
        //if (col.gameObject.CompareTag("Penguin") || col.gameObject.CompareTag("MoonMan") || col.gameObject.CompareTag("ButtLady"))
        //{
        //    //Instantiate(OnContact, transform.localPosition, transform.localRotation);
        //    Destroy(gameObject);
        //}

    }
}