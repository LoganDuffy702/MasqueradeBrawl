using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimTest : MonoBehaviour {

   
    GameObject PlayerSprite;
    private Vector3 NewInput;
    private float Heading;
    private Vector3 NewRotation;
    public enum Player { Player1, Player2, Player3, Player4 }
    public Player choosePlayr;
  
    void Start () {

        switch (choosePlayr)
        {
            case Player.Player1:
                PlayerSprite = GameObject.Find("_Player1_Anim");
                break;
            case Player.Player2:
                PlayerSprite = GameObject.Find("_Player2_Anim");
                break;
            case Player.Player3:
                break;
            case Player.Player4:
                break;
            default:
                break;
        }
        
    }

    // Update is called once per frame
    void Update () {

        switch (choosePlayr)
        {
            case Player.Player1:
                gameObject.transform.localPosition = new Vector3(0f, -.108f, 0f);
                NewInput = new Vector3(Input.GetAxis("HorAim"), Input.GetAxis("VerAim"), 0f);

                if (NewInput.sqrMagnitude < 0.1f)
                {
                    return;
                }

                NewInput.Normalize();
                Heading = Vector3.Dot(Vector3.up, NewInput);
                NewRotation = transform.rotation.eulerAngles;
                NewRotation.z = Heading * 90;

                if (NewInput.x >= 0)
                {
                    NewRotation.y = 180f;
                    PlayerSprite.GetComponent<SpriteRenderer>().flipX = true;


                }
                if (NewInput.x <= 0)
                {
                    NewRotation.y = 0f;
                    PlayerSprite.GetComponent<SpriteRenderer>().flipX = false;

                }

                transform.rotation = Quaternion.Euler(NewRotation);
                break;
            case Player.Player2:
                gameObject.transform.localPosition = new Vector3(0f, -.108f, 0f);
                NewInput = new Vector3(Input.GetAxis("HorAim"), Input.GetAxis("VerAim"), 0f);

                if (NewInput.sqrMagnitude < 0.1f)
                {
                    return;
                }

                NewInput.Normalize();
                Heading = Vector3.Dot(Vector3.up, NewInput);
                NewRotation = transform.rotation.eulerAngles;
                NewRotation.z = Heading * 90;

                if (NewInput.x >= 0)
                {
                    NewRotation.y = 180f;
                    PlayerSprite.GetComponent<SpriteRenderer>().flipX = true;


                }
                if (NewInput.x <= 0)
                {
                    NewRotation.y = 0f;
                    PlayerSprite.GetComponent<SpriteRenderer>().flipX = false;

                }

                transform.rotation = Quaternion.Euler(NewRotation);
                break;
            case Player.Player3:
                break;
            case Player.Player4:
                break;
            default:
                break;
        }

       
    }
}
