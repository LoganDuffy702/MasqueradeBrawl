using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slow_Fast_Bullet : MonoBehaviour
{

    public int MoveSpeed;
    public float DestroyFade = 1;
    public bool TimedDeath;
    public float FireDelay;
    public GameObject OnContact;
    public int Speediterator;

    // Use this for initialization
    void Start()
    {

    }

    private void FixedUpdate()
    {
        transform.Translate(Vector3.left * Time.deltaTime * MoveSpeed);

        Destroy(gameObject, DestroyFade);
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.CompareTag("Walls"))
        {
            Instantiate(OnContact, transform.localPosition, transform.localRotation);
            Destroy(gameObject);
        }
        if (col.gameObject.CompareTag("Player1") || col.gameObject.CompareTag("Player2"))
        {
            Instantiate(OnContact, transform.localPosition, transform.localRotation);
            Destroy(gameObject);
        }

    }


    public IEnumerator MoveDelay()
    {
        float MoveDelay = 1 / FireDelay; //Decides the delay between each shot
        for (int i = 0; i < Speediterator; i++)
        {
            yield return new WaitForSeconds(MoveDelay); //Waits so many seconds before firing
            transform.Translate(Vector3.left * Time.deltaTime * MoveSpeed);
        }

    }
}
