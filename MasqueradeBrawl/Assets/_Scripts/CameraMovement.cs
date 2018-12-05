using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    //public GameObject Player1, Player2, Player3, Player4;

    public List<GameObject> Players;
    public float MoveSpeed = 1;
    public float Yoffset = 0;
    //public enum Player { Two_Players, Three_Players, Four_Players }
    //public Player PlayerCount;
    
    public float tempX;
    public float tempY;
    public bool Showwinner = false;
    
    Vector3 NewPosition;
    public bool touched;

    Camera MyCam;
    private Vector3 velocity = Vector3.zero;

    public float MaxZoom = 30f;
    public float MinZoom = 23f;
    public int TotalPlayer = 0;
    public float DistanceTrigVal = 90f;
    
    public float speed;
    // Use this for initialization
    void Start() {
        MyCam = gameObject.GetComponent<Camera>();

    }
   
    Vector3 FindCenter()
    {
        if (Players.Count == 1)
        {
            //Debug.Log("OnePlayer found");
            return new Vector3(0,0,0);
        }
        var bounds = new Bounds(Players[0].GetComponent<Transform>().position, Vector3.zero);
        for (int i = 0; i < Players.Count; i++)
        {
            bounds.Encapsulate(Players[i].GetComponent<Transform>().position);
        }
        return bounds.center;
    }

    float GetGreatestDistance()
    {
        
        var bounds = new Bounds(Players[0].GetComponent<Transform>().position, Vector3.zero);
        for (int i = 0; i < Players.Count; i++)
        {
            bounds.Encapsulate(Players[i].GetComponent<Transform>().position);
        }
        return bounds.size.x;
    }
	// Update is called once per frame
	void FixedUpdate () {
        
        
        if (touched == true)
        {
           
            Vector3 TempPos = new Vector3(tempX,tempY+Yoffset, -64f);
            gameObject.transform.position = Vector3.SmoothDamp(gameObject.transform.position, TempPos, ref velocity, MoveSpeed);

            float newZoom = Mathf.Lerp(MaxZoom, MinZoom, GetGreatestDistance() / DistanceTrigVal);
            
            MyCam.orthographicSize = Mathf.Lerp(newZoom, MyCam.orthographicSize, Time.deltaTime*speed+2);
           


        }
        else if (touched == false)
        {
            
            NewPosition = new Vector3(FindCenter().x, FindCenter().y+Yoffset,-64f);
            gameObject.transform.position = Vector3.SmoothDamp(gameObject.transform.position, NewPosition, ref velocity, MoveSpeed+.3f);

            float newZoom = Mathf.Lerp(MaxZoom, MinZoom, GetGreatestDistance() / DistanceTrigVal);
            MyCam.orthographicSize = Mathf.Lerp(MyCam.orthographicSize, newZoom, Time.deltaTime*speed);
            

        }
        if (Showwinner == true)
        {
            NewPosition = new Vector3(Players[0].GetComponent<Transform>().position.x, Players[0].GetComponent<Transform>().position.y + Yoffset, -64f);
            gameObject.transform.position = Vector3.SmoothDamp(gameObject.transform.position, NewPosition, ref velocity, MoveSpeed + .3f);

            float newZoom = Mathf.Lerp(MaxZoom, MinZoom, GetGreatestDistance() / DistanceTrigVal);
            MyCam.orthographicSize = Mathf.Lerp(MyCam.orthographicSize, newZoom, Time.deltaTime * speed);
        }

	}
    public void DeleteUpdate(string PlayerName)
    {
       
        //Debug.Log("DeleteUpdate " + PlayerName);
        for (int i = 0; i < Players.Count; i++)
        {
            if (Players[i].name == PlayerName)
            {
                Debug.Log("DeleteUpdate " + PlayerName);
                //Players.RemoveAt(i);
            }
        }
       
    }
}
