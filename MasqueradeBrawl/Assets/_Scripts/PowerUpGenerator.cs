using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpGenerator : MonoBehaviour {
    public List<GameObject> PowerUpsObject = new List<GameObject>();
    private GameObject lastGroundObject;
    public bool UseSpeed;
    public bool Touched = false;
    public float maxOffsetX = 3f;
    public float maxOffsetY = 3f;
    private Vector3 lastSpawnPosition;
    
    public float SpawnTimer;
    private bool spawnfloor = true;
    public float speed;

    // Use this for initialization
    void Start()
    {
        //If you want instant spawn, but not needed.
        //lastGroundObject = Instantiate(RandomGroundObject());
        //lastGroundObject.transform.position = transform.position;//+ Vector2.down * 2f + Vector2.forward * 2f
        //lastSpawnPosition = lastGroundObject.transform.Find("EndPoint").position;
        //StartCoroutine(SpeedUpTimer());
    }

    // Update is called once per frame
    void Update()
    {

        if (spawnfloor == true) //Change to timer (old)Vector3.Distance(lastSpawnPosition, player.transform.position) < genDistance
        {
            SpawnNewGroundObject();
            //lastSpawnPosition = lastGroundObject.transform.Find("EndPoint").position;
            StartCoroutine(Timer());
            spawnfloor = false;
        }

    }

    private GameObject RandomGroundObject()
    {
        int r = Mathf.FloorToInt(Random.value * PowerUpsObject.Count);
        return PowerUpsObject[r];
    }
    public IEnumerator Timer()
    {
        yield return new WaitForSeconds(SpawnTimer);
        spawnfloor = true;
    }
    

    private void SpawnNewGroundObject()
    {
        //var lastEndPoint = lastGroundObject.transform.Find("EndPoint");

        lastGroundObject = Instantiate(RandomGroundObject());

        // var thisStartPoint = lastGroundObject.transform.Find("StartPoint");

        // use the 'endPoint' on the last ground object and the 'start point' on the new one
        // position the new ground object with the end of this one touching the end of the last one
        //lastGroundObject.transform.position = lastEndPoint.position - (thisStartPoint.position - lastGroundObject.transform.position);
        lastGroundObject.transform.position = transform.position;

        // translate the new game object by a random amount left or right
        lastGroundObject.transform.position += new Vector3(maxOffsetX* (Random.value * 2f - 1f), maxOffsetY * (Random.value * 2f - 1f),0f);
        if (UseSpeed == true)
        {
            lastGroundObject.GetComponent<FloorMovementRedux>().MoveSpeed = speed;
        }
        
    }
}
