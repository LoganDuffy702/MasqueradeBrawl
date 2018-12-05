using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimTest : MonoBehaviour {

   
    public GameObject PlayerSprite;
    private Vector3 NewInput;
    private float Heading;
    private Vector3 NewRotation;

    public enum Player { MoonMan, Penguin, ButtLady, FoxMan }
    public enum PlayerPos { Player1,Player2,Player3,Player4}
    public PlayerPos PlayerController;
    public Player choosePlayr;
  
    void Start () {

       
        gameObject.GetComponentInChildren<RigidWeapon>().enabled = true;
        
    }

    // Update is called once per frame
    void Update () {

        switch (choosePlayr)
        {
            case Player.MoonMan:
                gameObject.transform.localPosition = new Vector3(0f, -.108f, 0f);
                switch (PlayerController)
                {
                    case PlayerPos.Player1:
                        NewInput = new Vector3(Input.GetAxis("HorAim"), Input.GetAxis("VerAim"), 0f);
                        break;
                    case PlayerPos.Player2:
                        NewInput = new Vector3(Input.GetAxis("HorAim2"), Input.GetAxis("VerAim2"), 0f);
                        break;
                    case PlayerPos.Player3:
                        NewInput = new Vector3(Input.GetAxis("HorAim3"), Input.GetAxis("VerAim3"), 0f);
                        break;
                    case PlayerPos.Player4:
                        NewInput = new Vector3(Input.GetAxis("HorAim4"), Input.GetAxis("VerAim4"), 0f);
                        break;
                    default:
                        break;
                }
                

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
            case Player.Penguin:
                gameObject.transform.localPosition = new Vector3(0f, -0.144f, 0f);
                switch (PlayerController)
                {
                    case PlayerPos.Player1:
                        NewInput = new Vector3(Input.GetAxis("HorAim"), Input.GetAxis("VerAim"), 0f);
                        break;
                    case PlayerPos.Player2:
                        NewInput = new Vector3(Input.GetAxis("HorAim2"), Input.GetAxis("VerAim2"), 0f);
                        break;
                    case PlayerPos.Player3:
                        NewInput = new Vector3(Input.GetAxis("HorAim3"), Input.GetAxis("VerAim3"), 0f);
                        break;
                    case PlayerPos.Player4:
                        NewInput = new Vector3(Input.GetAxis("HorAim4"), Input.GetAxis("VerAim4"), 0f);
                        break;
                    default:
                        break;
                }
                
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
                    //gameObject.transform.localPosition = new Vector3(-.12f, 0.09f, 0);


                }
                if (NewInput.x <= 0)
                {
                    
                    NewRotation.y = 0f;
                    PlayerSprite.GetComponent<SpriteRenderer>().flipX = false;
                    //gameObject.transform.localPosition = new Vector3(.12f, 0.09f, 0);

                }

                transform.rotation = Quaternion.Euler(NewRotation);
                break;
            case Player.ButtLady:
                //gameObject.transform.localPosition = new Vector3(0f, -.108f, 0f);
                switch (PlayerController)
                {
                    case PlayerPos.Player1:
                        NewInput = new Vector3(Input.GetAxis("HorAim"), Input.GetAxis("VerAim"), 0f);
                        break;
                    case PlayerPos.Player2:
                        NewInput = new Vector3(Input.GetAxis("HorAim2"), Input.GetAxis("VerAim2"), 0f);
                        break;
                    case PlayerPos.Player3:
                        NewInput = new Vector3(Input.GetAxis("HorAim3"), Input.GetAxis("VerAim3"), 0f);
                        break;
                    case PlayerPos.Player4:
                        NewInput = new Vector3(Input.GetAxis("HorAim4"), Input.GetAxis("VerAim4"), 0f);
                        break;
                    default:
                        break;
                }


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
            case Player.FoxMan:
                //gameObject.transform.localPosition = new Vector3(0f, -.108f, 0f);
                switch (PlayerController)
                {
                    case PlayerPos.Player1:
                        NewInput = new Vector3(Input.GetAxis("HorAim"), Input.GetAxis("VerAim"), 0f);
                        break;
                    case PlayerPos.Player2:
                        NewInput = new Vector3(Input.GetAxis("HorAim2"), Input.GetAxis("VerAim2"), 0f);
                        break;
                    case PlayerPos.Player3:
                        NewInput = new Vector3(Input.GetAxis("HorAim3"), Input.GetAxis("VerAim3"), 0f);
                        break;
                    case PlayerPos.Player4:
                        NewInput = new Vector3(Input.GetAxis("HorAim4"), Input.GetAxis("VerAim4"), 0f);
                        break;
                    default:
                        break;
                }

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
                    gameObject.transform.localPosition = new Vector3(0f, .15f, 0);


                }
                if (NewInput.x <= 0)
                {

                    NewRotation.y = 0f;
                    PlayerSprite.GetComponent<SpriteRenderer>().flipX = false;
                    gameObject.transform.localPosition = new Vector3(0f, .15f, 0);

                }

                transform.rotation = Quaternion.Euler(NewRotation);
                break;
            default:
                break;
        }

       
    }
}
