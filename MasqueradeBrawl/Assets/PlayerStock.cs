using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStock : MonoBehaviour {

    public GameObject Player;
    public GameObject StockImage;
    public GameObject StockLocation;
    public GameObject RemoveStock;
    int count = 0;
	void Start () {

        float TEst = Player.GetComponent<PlayerHealth>().PlayerStock;
        Debug.Log(TEst);
        for (int i = 0; i < Player.GetComponent<PlayerHealth>().PlayerStock; i++)
        {
            var StockClone = Instantiate(StockImage);
            StockClone.transform.SetParent(StockLocation.transform);
            StockClone.transform.localScale = new Vector2(0.06f, .06f);
            StockClone.transform.localPosition = new Vector3(21.3f + (i *10f), 3.09f, 0f);

        }
	}

    public void DeathStock(int lifecount)
    {
        Debug.Log("remove Stock");
        count += lifecount;
        for (int i = 0; i < count; i++)
        {
            var StockClone = Instantiate(RemoveStock);
            StockClone.transform.SetParent(StockLocation.transform);
            StockClone.transform.localScale = new Vector2(0.06f, .06f);
            StockClone.transform.localPosition = new Vector3(21.3f + (i * 10f), 3.09f, 0f);

        }
    }
	
	
}
