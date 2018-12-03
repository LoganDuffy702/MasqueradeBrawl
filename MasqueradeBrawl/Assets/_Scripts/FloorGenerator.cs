using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorGenerator : MonoBehaviour {

    public List<GameObject> groundObjects = new List<GameObject>();
    private GameObject lastGroundObject;
    public float maxOffset = 3f;
    private Vector3 lastSpawnPosition;
    //public float duration;
    public float LowestDuration, HighestDuration;
    private bool spawnfloor = true;
    public bool GoLeft = false;
    public bool GoRight = false;
    public float speed;

    // Use this for initialization
    void Start () {
        //If you want instant spawn, but not needed.
        //lastGroundObject = Instantiate(RandomGroundObject());
        //lastGroundObject.transform.position = transform.position;//+ Vector2.down * 2f + Vector2.forward * 2f
        //lastSpawnPosition = lastGroundObject.transform.Find("EndPoint").position;
        //StartCoroutine(SpeedUpTimer());
    }
	
	// Update is called once per frame
	void Update () {
        
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
        int r = Mathf.FloorToInt(Random.value * groundObjects.Count);
        return groundObjects[r];
    }
    public IEnumerator Timer()
    {
        yield return new WaitForSeconds(Random.Range(LowestDuration, HighestDuration));
        spawnfloor = true;
    }
    public IEnumerator SpeedUpTimer()
    {
        yield return new WaitForSeconds(10f);
        StartCoroutine(SpeedUpTimer());
        speed = speed + .5f;
        //duration = duration - .2f;
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
        lastGroundObject.GetComponent<FloorMovementRedux>().MoveSpeed = speed;
        // translate the new game object by a random amount left or right
        //lastGroundObject.transform.position += Vector3.right * maxOffset * (Random.value * 2f - 1f);//(For Rigidbody)
        
        
        
    }
}
