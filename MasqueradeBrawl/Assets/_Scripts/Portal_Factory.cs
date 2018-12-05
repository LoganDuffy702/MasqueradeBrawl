using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal_Factory : MonoBehaviour {

    public bool ReleaseUp,Laundry;
    //public bool ReleaseRight;
    //public bool ReleaseLeft;
    public bool RandomExit;
    public float ExitSpeed = 2;
    public int tempSpeed;
    public AudioSource doorsound;
    

    public List<GameObject> exitList = new List<GameObject>();
    public float delay;
    private CameraMovement cam;
    Animator anim;
    //private List<Transform> Ptrans = new List<Transform>();
   

	void Start () {
        cam = GameObject.Find("Main Camera").GetComponent<CameraMovement>();

        anim = gameObject.GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Penguin") || other.gameObject.CompareTag("MoonMan") ||
            other.gameObject.CompareTag("ButtLady")|| other.gameObject.CompareTag("Foxy"))
        {
            
            doorsound.Play();
            anim.SetBool("Open", true);
            if (ReleaseUp == true && RandomExit == true)
            {
                other.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                tempSpeed = other.gameObject.GetComponent<PlayerMovementRedux>().Speed;
                other.gameObject.GetComponent<PlayerMovementRedux>().Speed = 3;
                int r = Mathf.Abs(Random.Range(-1, 2));
                if (r == 2)
                    r = 0;

                Vector3 temp = exitList[r].transform.position;
                cam.touched = true;
                cam.tempX = temp.x/2;
                cam.tempY = temp.y/2;

                StartCoroutine(DelayExit(other.gameObject, r));

            }
            else if (RandomExit == true)
            {
                
                other.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                tempSpeed = other.gameObject.GetComponent<PlayerMovementRedux>().Speed;
                other.gameObject.GetComponent<PlayerMovementRedux>().Speed = 3;
                
                int r = Mathf.Abs(Random.Range(0, exitList.Count));
                //Debug.Log(r);
                Vector3 temp = exitList[r].transform.position;
                cam.touched = true;
                cam.tempX = temp.x/3;
                cam.tempY = temp.y/3;

                StartCoroutine(DelayExit(other.gameObject, r));
                
            }
           
        }
    }

    public IEnumerator DelayExit(GameObject other, int Rnum)
    {
        yield return new WaitForSeconds(delay);
       
        if (ReleaseUp == true)
        {
            other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * ExitSpeed);
            other.gameObject.transform.position = exitList[Rnum].transform.position;
            if (tempSpeed <= 0)
            {
                tempSpeed = 15;
            }
            other.gameObject.GetComponent<PlayerMovementRedux>().Speed = tempSpeed;
            
        }
        else
        {
            other.gameObject.transform.position = exitList[Rnum].transform.position;
            if (tempSpeed <= 0)
            {
                tempSpeed = 15;
            }
            other.gameObject.GetComponent<PlayerMovementRedux>().Speed = tempSpeed;
            if (Rnum == 0 && Laundry)
            {
                Debug.Log("go left");
                other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.right * ExitSpeed);
                //other.gameObject.transform.position = exitList[Rnum].transform.position;
                //other.gameObject.GetComponent<PlayerMovementRedux>().Speed = tempSpeed;
            }
            else if (Rnum == 1 && Laundry)
            {
                Debug.Log("go right");
                other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.left * ExitSpeed);
                //other.gameObject.transform.position = exitList[Rnum].transform.position;
               // other.gameObject.GetComponent<PlayerMovementRedux>().Speed = tempSpeed;
            }
           
        }

        yield return new WaitForSeconds(.3f);
        anim.SetBool("Open", false);
        cam.touched = false;
    }
}
