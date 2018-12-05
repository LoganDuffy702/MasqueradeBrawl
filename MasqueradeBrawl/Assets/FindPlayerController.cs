using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindPlayerController : MonoBehaviour {

    private List<int> AssignedControllers = new List<int>();
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
     void Update () {
        for (int i = 1; i < 5; i++)
        {
            if (AssignedControllers.Contains(i))
                continue;
            if (Input.GetButtonDown("Player"+ i + "_A"))
            {
                Debug.Log("Player " + i + " was pressed");

                AddPlayerControllers(i);
                break;
            }
            
        }
  
    }
    public void AddPlayerControllers(int controller)
    {
        AssignedControllers.Add(controller);

        //Add check for if player added
        if (controller == 1)
        {
            GameObject.Find("Player1_controlls").GetComponent<Player1Selection>().Activated();
            //GameObject.Find("Player1_controlls").GetComponent<Player1Selection>().Canmove = true;
            //GameObject.Find("Player1_controlls").GetComponent<Player1Selection>().CanRemove = false;
        }
        else if (controller == 2)
        {
            GameObject.Find("Player2_controlls").GetComponent<Player2Selection>().Activated();
            //GameObject.Find("Player2_controlls").GetComponent<Player2Selection>().Canmove = true;
            //GameObject.Find("Player2_controlls").GetComponent<Player2Selection>().Canmove = true;
        } else if (controller == 3)
        {
            GameObject.Find("Player3_controlls").GetComponent<Player3Selection>().Activated();
           // GameObject.Find("Player3_controlls").GetComponent<Player3Selection>().Canmove = true;
        } else if (controller == 4)
        {
            GameObject.Find("Player4_controlls").GetComponent<Player4Selection>().Activated();
           // GameObject.Find("Player4_controlls").GetComponent<Player4Selection>().Canmove = true;
        }
        //GameObject.Find("Player1_controlls").GetComponent<Player1Selection>().activateMe = true;
        //Debug.Log("AddingPlayer " + controller);
    }
}
