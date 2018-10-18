using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal_Factory : MonoBehaviour {

    public bool ReleaseUp;
    //public bool ReleaseRight;
    //public bool ReleaseLeft;
    public bool RandomExit;
    public float ExitSpeed = 2;

    public List<GameObject> exitList = new List<GameObject>();
    public float delay;
    private CameraMovement cam;
    //private List<Transform> Ptrans = new List<Transform>();
   

	void Start () {
        cam = GameObject.Find("Main Camera").GetComponent<CameraMovement>();
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player1") || other.gameObject.CompareTag("Player2"))
        {
            if (ReleaseUp == true && RandomExit == true)
            {
                other.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                int r = Mathf.Abs(Random.Range(-1, 2));
                if (r == 2)
                    r = 0;

                Vector3 temp = exitList[r].transform.position;
                cam.touched = true;
                cam.tempX = temp.x;
                cam.tempY = temp.y;

                StartCoroutine(DelayExit(other.gameObject, r));

            }
            else if (RandomExit == true)
            {
                other.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                other.gameObject.GetComponent<PlayerMovementRedux>().Speed = 0;
                int r = Mathf.Abs(Random.Range(0, exitList.Count));
                Vector3 temp = exitList[r].transform.position;
                
                cam.touched = true;
                cam.tempX = temp.x;
                cam.tempY = temp.y;

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
            other.gameObject.GetComponent<PlayerMovementRedux>().Speed = 20;
            cam.touched = false;
        }
        else
        {
            other.gameObject.transform.position = exitList[Rnum].transform.position;
            other.gameObject.GetComponent<PlayerMovementRedux>().Speed = 20;
            cam.touched = false;
        }
    }
}

//else if (ReleaseRight == true)
//{                
//    other.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
//    other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * ExitSpeed);
//    other.gameObject.transform.position = EndPoint;
//}
//else if (ReleaseLeft == true)
//{                
//    other.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
//    other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.left * ExitSpeed);
//    other.gameObject.transform.position = EndPoint;
//}