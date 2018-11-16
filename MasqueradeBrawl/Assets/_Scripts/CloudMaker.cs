using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMaker : MonoBehaviour {

    public List<GameObject> groundObjects = new List<GameObject>();
    private GameObject lastGroundObject;
    public float maxOffset = 3f;
    private Vector3 lastSpawnPosition;
    public float duration;
    private bool spawnfloor = true;
    
    public float speed;

   

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
        int r = Mathf.FloorToInt(Random.value * groundObjects.Count);
        
        return groundObjects[r];
    }
    public IEnumerator Timer()
    {
        yield return new WaitForSeconds(duration);
        spawnfloor = true;
    }
    public IEnumerator SpeedUpTimer()
    {
        yield return new WaitForSeconds(10f);
        StartCoroutine(SpeedUpTimer());
        speed = speed + .5f;
        duration = duration - .2f;
    }
    private void SpawnNewGroundObject()
    {

        lastGroundObject = Instantiate(RandomGroundObject());

        lastGroundObject.transform.position = transform.position;
        lastGroundObject.transform.localScale = new Vector3(5.1f, 5f, 0f);

        lastGroundObject.transform.position += Vector3.right * maxOffset * (Random.value * 2f - 1f);
       // lastGroundObject.GetComponent<Rigidbody2D>().velocity = (Vector2.left * speed);
   
    }
}
