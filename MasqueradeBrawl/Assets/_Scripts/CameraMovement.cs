using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public GameObject Player1, Player2, Player3, Player4;

    public enum Player { Two_Players, Three_Players, Four_Players }
    public Player PlayerCount;
    public float Newx;
    public float tempX;
    public float tempY;
    public float NewY;
    Vector3 NewPosition;
    public bool touched;

    Camera MyCam;
    private Vector3 velocity = Vector3.zero;

    Vector3 P1, P2, P3, P4;
    public float Xoffset,Yoffset;
    public float speed;
    // Use this for initialization
    void Start () {
        MyCam = gameObject.GetComponent<Camera>();
        switch (PlayerCount)
        {
            case Player.Two_Players:
                Player1 = GameObject.Find("_MoonMan");
                Player2 = GameObject.Find("_Penguin");
                break;
            case Player.Three_Players:
                Player1 = GameObject.Find("_MoonMan");
                Player2 = GameObject.Find("_Penguin");
                Player3 = GameObject.Find("_ButtLady");
                break;
            case Player.Four_Players:
                Player1 = GameObject.Find("_Player1");
                Player2 = GameObject.Find("_Player2");
                Player3 = GameObject.Find("_Player3");
                Player4 = GameObject.Find("_Player4");
                break;
            default:
                break;
        }
        
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        
        if (touched == true)
        {
            Newx = ((tempX + Player2.transform.position.x) / 2);
            NewY = ((tempY+ Player2.transform.position.y) / 2);
            Vector3 difference = (Player1.transform.position - Player2.transform.position);
            NewPosition = new Vector3(Newx,NewY, -64);
            gameObject.transform.position = Vector3.SmoothDamp(gameObject.transform.position, NewPosition, ref velocity, speed);
            
            if (Mathf.Abs(difference.x) >= 70f || Mathf.Abs(difference.y) >= 30f)
            {
                MyCam.orthographicSize = MyCam.orthographicSize + (Time.deltaTime * 10);
                if (MyCam.orthographicSize >= 29f)
                {
                    MyCam.orthographicSize = 29f;
                }
            }
            else
            {
                MyCam.orthographicSize = MyCam.orthographicSize - (Time.deltaTime * 10);
                if (MyCam.orthographicSize <= 24f)
                {
                    MyCam.orthographicSize = 24f;
                }
            }
        }
        else if (touched == false)
        {
            Newx = ((Player1.transform.position.x + Player2.transform.position.x) / 2);
            NewY = ((Player1.transform.position.y + Player2.transform.position.y) / 2);
            Vector3 difference = (Player1.transform.position - Player2.transform.position);
            NewPosition = new Vector3(Newx, NewY, -64);
            gameObject.transform.position = Vector3.SmoothDamp(gameObject.transform.position, NewPosition, ref velocity, speed);

            if (Mathf.Abs(difference.x) >= 70f || Mathf.Abs(difference.y) >= 30f)
            {
                MyCam.orthographicSize = MyCam.orthographicSize + (Time.deltaTime * 10);
                if (MyCam.orthographicSize >= 29f)
                {
                    MyCam.orthographicSize = 29f;
                }
            }
            else
            {
                MyCam.orthographicSize = MyCam.orthographicSize - (Time.deltaTime * 10);
                if (MyCam.orthographicSize <= 24f)
                {
                    MyCam.orthographicSize = 24f;
                }
            }
        }

       
      
        //if (gameObject.transform.position.y <= 1f)
        //{
        //    gameObject.transform.position = new Vector3(Newx + Xoffset, (NewY + (Time.deltaTime*(3*Yoffset))), 0);
        //}
	}
   
}
